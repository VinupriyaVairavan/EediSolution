using API.Data;
using API.Dtos;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class QuestionRepository(AssignmentDbContext context) : IQuestionRepository
{
    public async Task<SubTopic?> GetSubTopicByIdAsync(int id)
    {
       return await context.SubTopics.FirstOrDefaultAsync(s => s.Id == id);
    }
    
    public async Task<Question?> GetQuestionByIdAsync(int id)
    {
        return await context.Questions.FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<List<QuestionOption>> GetQuestionsOptionsByQuestionId(int id)
    {
        return await context.QuestionOptions.Where(q => q.QuestionId == id).ToListAsync();
    }

    public async Task<QuestionOption?> GetQuestionOptionByIdAsync(int questionId, int optionId)
    {
        var options = await 
            GetQuestionsOptionsByQuestionId(questionId);

        return options.FirstOrDefault(o => o.QuestionId == questionId && o.Id == optionId);
    }
}