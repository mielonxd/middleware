using Wangkanai.Detection;
using Wangkanai.Detection.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Web;

namespace middleware.Middleware
{
    public class checking_the_browser
    {
        private RequestDelegate _next;
        public checking_the_browser(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpContext, IDetectionService detectionService)
        {
            var browser = detectionService.Browser.Name.ToString();
            if(browser == "Edge" || browser == "EdgeChromium" || browser == "InternetExplorer")
            {
                var response = httpContext.Response;
                response.Redirect("https://www.mozilla.org/pl/firefox/new/", true);
            }
            return _next(httpContext);
        }
    }
    public static class checking_the_browserExtensions
    {
        public static IApplicationBuilder Usechecking_the_browser(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<checking_the_browser>();
        }
    }
}
