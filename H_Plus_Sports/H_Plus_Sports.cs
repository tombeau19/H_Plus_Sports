using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace H_Plus_Sports
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class H_Plus_Sports
    {
        private readonly RequestDelegate _next;

        public H_Plus_Sports(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class H_Plus_SportsExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<H_Plus_Sports>();
        }
    }
}
