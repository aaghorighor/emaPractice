namespace Suftnet.Co.Ema.Api
{
    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.SpaServices.AngularCli;
    using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    using Microsoft.Net.Http.Headers;
    using Suftnet.Co.Ema.Api.Extensions;
    using Suftnet.Co.Ema.Api.Mappers;
    using Suftnet.Co.Ema.Api.Middleware.Security;
    using Suftnet.Co.Ema.Common;
    using Suftnet.Co.Ema.DataAccess.Identity;
    using System;
    using System.IO;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; set; }

        [Obsolete]
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mapper =>
            {
                mapper.AddProfile(new MappingProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.Cors();
            services.JsonOptions();
            services.HttpContextAccessor();
            services.IdentityContext(Configuration);
            services.JwtContext(Configuration);

            services.AddHsts(options =>
            {
                options.MaxAge = TimeSpan.FromDays(100);
                options.IncludeSubDomains = true;
                options.Preload = true;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("admin", policy => policy.RequireClaim(JwtClaimIdentifiers.USER_NAME, JwtClaimIdentifiers.USER_ID));
                options.AddPolicy("restricted", policy => policy.RequireClaim(JwtClaimIdentifiers.USER_ID));
            });

            services.AddIdentityCore<ApplicationUser>(o =>
            {              
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
            });

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "frontend/dist";
            });            

            return services.IoC();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Cors();
            app.UseSecurityHeadersMiddleware(new SecurityHeadersBuilder().AddDefaultSecurePolicy());
            app.UseHttpStatusCodeExceptionMiddleware();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Join(env.ContentRootPath, "frontend");
         
                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");                   
                }                

            });
        }    
    
    }
}
