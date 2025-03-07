using API.Data;
using API.Dtos;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class StudentRepository(AssignmentDbContext context) : IStudentRepository
{
    public async Task<List<Topic>> GetMisconceptionTopicsByStudentId(int studentId)
    {
        var misconceptions = await context.StudentAssignments
                .Where(a => a.StudentId == studentId && !a.IsValid)
                .Select(q => new
                {
                    q.Question.SubTopic.Topic,
                    q.Question.SubTopic,
                    q.Question,
                    q.ChosenOption
                }).ToListAsync();

        var topics = misconceptions
            .GroupBy(m => m.Topic)
            .Select(q => q.Key).ToList();
    
        return topics;
    }

    public async Task<SubTopic?> GetMisConceptionsForStudentBySubTopicId(int studentId, int subTopicId)
    {
        var misconceptions = await context.StudentAssignments
            .Where(a => a.StudentId == studentId && !a.IsValid &&
                        a.Question.SubTopicId == subTopicId)
            .Select(q => new
            {
                q.Question.SubTopic,
                q.Question,
                q.ChosenOption
            }).ToListAsync();

        var topics = misconceptions
            .Select(q => q.SubTopic).FirstOrDefault();
    
        return topics;
    }

    public async Task<Student?> GetStudentById(int studentId)
    {
        return await context.Students.FirstOrDefaultAsync(a => a.Id == studentId);
    }

    public async Task<StudentAssignment?> ReSubmitAnswerForStudentByQuestionId(int studentId, int questionId, int optionChosenId)
    {
        var assignment =
        await context.StudentAssignments
            .Where(s => s.StudentId == studentId && s.QuestionId == questionId).FirstOrDefaultAsync();

        var chosenOption = await 
            context.QuestionOptions.Where(qo => qo.QuestionId == questionId && qo.Id == optionChosenId)
                .FirstOrDefaultAsync();
        
        if (assignment is not null && chosenOption is not null)
        {
            assignment.ChosenOptionId = optionChosenId;
            assignment.AnswerFeedback = chosenOption.Description;
            assignment.IsValid = chosenOption.IsCorrectOption;
        }
        
        return assignment;
    }
}