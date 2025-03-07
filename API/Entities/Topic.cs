namespace API.Entities;

public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<SubTopic> SubTopics { get; set; }
}