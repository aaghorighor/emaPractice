﻿namespace EventHub.Api.Controllers
{   
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Suftnet.Co.Ema.Api.Extensions;
    using Suftnet.Co.Ema.Api.Infrastructure;
    using Suftnet.Co.Ema.Api.Models;
    using Suftnet.Co.Ema.Common;
    using Suftnet.Co.Ema.DataAccess.Identity;
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class AccountController : Controller
    {       
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtFactory _jwtFactory;
      
        public AccountController(UserManager<ApplicationUser> userManager, IJwtFactory jwtFactory)
        {
            _userManager = userManager;      
            _jwtFactory = jwtFactory;          
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

        #region private 
        private async Task<ClaimsIdentity> GetClaimsIdentity(string password, ApplicationUser user)
        {                                                
            if (await _userManager.CheckPasswordAsync(user, password))
            {
                return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(user));
            }
           
            return await Task.FromResult<ClaimsIdentity>(null);
        }
       
        #endregion
    }
}
