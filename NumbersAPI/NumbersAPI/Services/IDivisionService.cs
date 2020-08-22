using NumbersAPI.Models;

namespace NumbersAPI.Services
{
    public interface IDivisionService
    {
        DivisonResponseDto GetDivisionResult(DivisonRequestDto requestDto);
    }
}