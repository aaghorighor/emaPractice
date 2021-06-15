namespace EventHub.Api.Controllers
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using NLog;
    using Suftnet.Co.Ema.Api.Command;
    using Suftnet.Co.Ema.Api.Extensions;
    using Suftnet.Co.Ema.Api.Infrastructure;
    using Suftnet.Co.Ema.Api.Models;
    using Suftnet.Co.Ema.Common;
    using Suftnet.Co.Ema.DataAccess.Identity;
    using Suftnet.Cos.Model;
    using Suftnet.Cos.Services;
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class AccountController : Controller
    {       
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtFactory _jwtFactory;
        private readonly ISmtp _smtp;
        private readonly Config _config;
        private readonly ILogger<AccountController> _logger;
        private readonly IWebHostEnvironment _webHost;
        private readonly ITemplateCommand _templateCommand;

        public AccountController(UserManager<ApplicationUser> userManager, 
            IJwtFactory jwtFactory, ISmtp smtp, IOptions<Config> config, ILogger<AccountController> logger, IWebHostEnvironment webHost, ITemplateCommand templateCommand)
        {
            _userManager = userManager;      
            _jwtFactory = jwtFactory;
            _smtp = smtp;
            _logger = logger;
            _config = config.Value;
            _webHost = webHost;
            _templateCommand = templateCommand;
        }

        [HttpGet]
        [Route("ping")]
        public async Task<IActionResult> Ping()
        {
            return Ok(await Task.Run(() => DateTime.UtcNow));
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginDto loginModel)
        {
            if (!ModelState.IsValid)
            {                
                return BadRequest(new { message = ModelState.Errors() });
            }

            var user = await _userManager.FindByNameAsync(loginModel.UserName);

            if (user == null)
            {
                return BadRequest(new { message = ValidationError.PASSWORD_OR_USERNAME });
            }

            var identity = await GetClaimsIdentity(loginModel.Password, user);
            if (identity == null)
            {
                return BadRequest(new { message = ValidationError.PASSWORD_OR_USERNAME });
            }

            var jwt = await _jwtFactory.GenerateEncodedToken(loginModel.UserName, identity);
            var _model = new
            {
                id = user.Id,
                userName = user.FullName,
                userType = user.UserType,
                token = jwt
            };
            return new OkObjectResult(_model);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = ModelState.Errors() });
            }
                   
            Task.Run(()=>  SendSmtpEmail(registerDto));

            return Ok(true);
        }

        #region private 
        private async Task<ClaimsIdentity> GetClaimsIdentity(string password, ApplicationUser user)
        {                                                
            if (await _userManager.CheckPasswordAsync(user, password))
            {
                return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(user));
            }
           
            return await Task.FromResult<ClaimsIdentity>(null);
        }

        private void SendSmtpEmail(RegisterDto registerDto)
        {
            var messageModel = new MessageModel();
            var mailMessage = new System.Net.Mail.MailMessage();

            mailMessage.From = new System.Net.Mail.MailAddress(_config.SmtpEmail, _config.DisplayName);
            mailMessage.To.Add(registerDto.Email);
            mailMessage.Body = EmailMessage(registerDto);
            mailMessage.Subject = "Thank you for interest in Ema Practice";
            messageModel.MailMessage = new MailMessage(mailMessage);

            try
            {
                _smtp.MailProcessor(messageModel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Internal Server Error: {ex}");
            }
        }

        private string EmailMessage(RegisterDto registerDto)
        {
            _templateCommand.VIEW_PATH = System.IO.Path.Combine(_webHost.WebRootPath, "getstartedconfirmatiom.html");
            _templateCommand.Execute();

            Dictionary<string, string> build = new Dictionary<string, string>();
            var body = _templateCommand.View;

            build.Add("[customer]", registerDto.Company);
       
            foreach (KeyValuePair<string, string> _token in build)
            {
                body = body.Replace(_token.Key, _token.Value);
            }

            return body;
        }

        #endregion
    }
}
