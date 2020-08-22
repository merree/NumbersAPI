using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NumbersAPI.Models
{
    public class DivisonRequestDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "At least one dividend is required")]
        public List<int> Dividends { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Divisor must be greater than zero")]
        public double? Divisor { get; set; }
    }
}