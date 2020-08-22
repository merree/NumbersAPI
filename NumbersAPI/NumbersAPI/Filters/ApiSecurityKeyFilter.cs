using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using NumbersAPI.ActionResults;
using NumbersAPI.Models;

namespace NumbersAPI.Filters
{
    public class APISecurityKeyFilterAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var appConfig = context.HttpContext.RequestServices.GetService<AppConfig>();

            string api_key = context.HttpContext.Request.Headers["api-security-key"];

            if (string.IsNullOrWhiteSpace(api_key))
            {
                context.Result = new CustomNotFoundResult("Api security key not found in the header");
            }
            else if (api_key != appConfig.APISecurityKey)
            {
                context.Result = new CustomUnauthorizedResult("Invalid API security key");
            }
        }
    }
}
