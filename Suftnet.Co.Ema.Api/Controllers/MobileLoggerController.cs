namespace Suftnet.Co.Ema.Api.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Suftnet.Co.Ema.Api.Extensions;
    using Suftnet.Co.Ema.Api.Models;
    using Suftnet.Co.Ema.DataAccess.Actions;
    using Suftnet.Co.Ema.DataAccess.Interface;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class MobileLoggerController : BaseController
    {   
        private readonly IMapper _mapper;
        private readonly IRepository<MobileLogger> _mobileLogger;
        private readonly IUnitOfWork _unitOfWork;

        public MobileLoggerController(
            IMapper mapper, IRepository<MobileLogger> mobileLogger, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _mobileLogger = mobileLogger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("ping")]
        public async Task<IActionResult> Ping()
        {
            return Ok(await Task.Run(() => DateTime.UtcNow));
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(MobileLogDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = ModelState.Errors() });
            }                      

            var logger = new MobileLogger
            {
                ReportId = model.REPORT_ID,
                AndroidVersion = model.ANDROID_VERSION,
                AppVersionCode = model.APP_VERSION_CODE,
                AvailableMemSize = model.AVAILABLE_MEM_SIZE,
                CrashConfiguration = model.CRASH_CONFIGURATION.ToString(),
                Build = model.BUILD.ToString(),
                PackageName = model.PACKAGE_NAME,
                StackTrace = model.STACK_TRACE,

                CreatedDt = DateTime.UtcNow,
                CreatedBy = model.PACKAGE_NAME
            };           
                    
           _mobileLogger.Add(logger);
           _unitOfWork.SaveChanges();

            return Ok();
        }

    }
}
