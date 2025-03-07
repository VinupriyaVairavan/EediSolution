using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class Question
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = null!;
    public virtual ICollection<QuestionOption> Options { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Please provide a sub topic Id")]
    public int SubTopicId { get; set; }
    public virtual SubTopic SubTopic { get; set; } = null!;
}