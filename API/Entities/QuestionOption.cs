using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class QuestionOption
{
    public int Id { get; set; }
    public string Label { get; set; } = null!;
    
    [MaxLength(100, ErrorMessage = "Max length 100 characters")]
    public string Description { get; set; } = null!;
    
    public bool IsCorrectOption { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Please provide a question Id")]
    public int QuestionId { get; set; }
    public virtual Question Question { get; set; }
}