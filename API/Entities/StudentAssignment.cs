using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class StudentAssignment
{
    [Range(1, int.MaxValue, ErrorMessage = "Please provide a student Id")]
    public int StudentId { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Please provide a question Id")]
    public int QuestionId { get; set; }
    public virtual Question Question { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Please provide a option Id")]
    public int ChosenOptionId { get; set; }
    public virtual QuestionOption ChosenOption { get; set; }
    public bool IsValid { get; set; }
    public string  AnswerFeedback { get; set; }
}