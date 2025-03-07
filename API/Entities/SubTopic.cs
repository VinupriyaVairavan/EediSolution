using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class SubTopic
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    [Range(1, int.MaxValue, ErrorMessage = "Please provide a Topic Id")]
    public int TopicId { get; set; }
    public virtual Topic Topic { get; set; }
    
    public virtual ICollection<Question> Questions { get; set; }
}