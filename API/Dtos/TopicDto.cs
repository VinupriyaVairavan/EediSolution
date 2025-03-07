using API.Dtos;

namespace API.Dto;

public class TopicDto
{
    public int TopicId { get; set; }
    public string TopicName { get; set; } = null!;
    public IEnumerable<SubTopicDto> SubTopics { get; set; }
}