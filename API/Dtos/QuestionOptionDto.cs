namespace API.Dtos;

public class QuestionOptionDto
{
    public int QuestionOptionId { get; set; }
    public string Label { get; set; } = null!;
    public string Description { get; set; } = null!;
    
    public bool IsCorrectOption { get; set; }
}