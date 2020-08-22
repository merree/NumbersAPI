using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NumbersAPI.ActionResults
{
    public class CustomNotFoundResult : JsonResult
    {
        public CustomNotFoundResult(string message) : base(new { Message = message })
        {
            StatusCode = StatusCodes.Status404NotFound;
        }
    }
}
