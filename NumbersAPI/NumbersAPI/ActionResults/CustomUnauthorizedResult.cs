using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NumbersAPI.ActionResults
{
    public class CustomUnauthorizedResult : JsonResult
    {
        public CustomUnauthorizedResult(string message) : base(new { Message = message })
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }
    }
}
