using NumbersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersAPI.Services
{
    public class DivisionService : IDivisionService
    {
        public DivisonResponseDto GetDivisionResult(DivisonRequestDto requestDto)
        {
            DivisonResponseDto responseDto = new DivisonResponseDto();
            responseDto.Quotients = requestDto.Dividends.Select(dividend => (decimal)(dividend / (requestDto.Divisor ?? 1)));
            return responseDto;
        }
    }
}
