namespace API.Dtos;

public class StudentAssignmentDto
{
    public int StudentId { get; set; }
    public int QuestionId { get; set; }
    public int ChosenOptionId { get; set; }
    public string AnswerFeedback { get; set; } = null!;
    public bool IsValid { get; set; }
}