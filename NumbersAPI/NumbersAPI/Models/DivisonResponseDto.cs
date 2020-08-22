using System.Collections.Generic;

namespace NumbersAPI.Models
{
    public class DivisonResponseDto
    {
        public IEnumerable<decimal> Quotients { get; set; }
    }
}