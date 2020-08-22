using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumbersAPI.Filters;
using NumbersAPI.Models;
using NumbersAPI.Services;
using System;

namespace NumbersAPI.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]/[action]")]
    public class NumbersController : ControllerBase
    {
        private readonly IDivisionService divisionService;

        public NumbersController(IDivisionService divisionService)
        {
            this.divisionService = divisionService;
        }

        public IActionResult Start()
        {
            return Ok("API Started.");
        }

        [HttpPost]
        [APISecurityKeyFilter]
        public IActionResult GetDivisionResult([FromBody]DivisonRequestDto model)
        {
            try
            {
                DivisonResponseDto responseDto = divisionService.GetDivisionResult(model);
                return Ok(responseDto);
            }
            catch (Exception ex)
            {
                return ThrowInternalServerError(ex);
            }
            
        }

        private IActionResult ThrowInternalServerError(Exception ex, string message = "")
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new
            {
                Message = "Oops! Something went wrong!",
                ExceptionMessage = message,
                ExceptionType = "Exception"
            });
        }
    }
}
