using API.Entities;

namespace API.Repositories;

public interface IQuestionRepository
{
    Task<SubTopic?> GetSubTopicByIdAsync(int id);
    Task<Question?> GetQuestionByIdAsync(int id);
    Task<List<QuestionOption>> GetQuestionsOptionsByQuestionId(int id);
    
    Task<QuestionOption?> GetQuestionOptionByIdAsync(int questionId, int optionId);
}