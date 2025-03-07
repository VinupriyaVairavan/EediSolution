using API.Dto;

namespace API.Dtos;

public class QuestionDto
{
    public int QuestionId { get; set; }
    public string ImageUrl { get; set; } = null!;
    
    public IEnumerable<QuestionOptionDto> ChosenOptions { get; set; }
}