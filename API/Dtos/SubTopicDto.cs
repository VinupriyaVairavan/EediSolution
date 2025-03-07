
namespace API.Dtos;

public class SubTopicDto
{
    public int SubTopicId { get; set; }
    public string SubTopicTitle { get; set; } = null!;
    
    public int MisconceptionCount { get; set; }
    public IEnumerable<QuestionDto> Questions { get; set; }
}