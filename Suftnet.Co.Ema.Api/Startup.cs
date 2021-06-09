namespace Suftnet.Co.Ema.Api
{
    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
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

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; set; }

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
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = (context) =>
                {
                    var headers = context.Context.Response.GetTypedHeaders();
                    headers.CacheControl = new CacheControlHeaderValue
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(60)
                    };
                }
            });
            app.UseSpaStaticFiles();
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add(
                    "Content-Security-Policy",
                    "frame-ancestors 'self' https:   ; " +
                    "default-src 'self' https:   azure.net ; " +
                    "child-src 'self' https:  ; " +
                    "style-src 'self' blob: 'unsafe-inline' ; " +
                    "font-src 'self' https: data: ; " +
                    "script-src 'self' https: 'unsafe-eval' ; " +
                    "connect-src 'self' https: wss: ; " +
                    "img-src 'self' https: data: ; ");

                context.Response.Headers.Add(
                    "Strict-Transport-Security",
                    "max-age=86400; includeSubDomains");

                context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                context.Response.Headers.Add("X-Xss-Protection", "1");
                await next();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "frontend";
                spa.Options.StartupTimeout = new TimeSpan(0, 2, 0);

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }

            });
        }    
    
    }
}
