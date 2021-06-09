﻿namespace Suftnet.Co.Ema.Api.Extensions
{
    using Suftnet.Co.Ema.Api.Middleware.Security;
    using Suftnet.Co.Ema.Api.Middleware.Exception;
    using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
     using Microsoft.AspNetCore.Builder;
    using System;
   
    public static class Configures
    {
        public static void Cors(this IApplicationBuilder app)
        {
            app.UseCors(
                options => options.AllowAnyOrigin()
            );                       
        }             
        public static IApplicationBuilder UseSecurityHeadersMiddleware(this IApplicationBuilder app, SecurityHeadersBuilder builder)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            return app.UseMiddleware<SecurityHeadersMiddleware>(builder.Build());
        }

        public static IApplicationBuilder UseHttpStatusCodeExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpStatusCodeExceptionMiddleware>();
        }
    }
}
