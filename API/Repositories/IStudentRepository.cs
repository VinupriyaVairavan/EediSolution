using API.Entities;

namespace API.Repositories;

public interface IStudentRepository
{
    Task<Student?> GetStudentById(int studentId);
    Task<List<Topic>> GetMisconceptionTopicsByStudentId(int studentId);

    Task<SubTopic?> GetMisConceptionsForStudentBySubTopicId(int studentId, int subTopicId);
    Task<StudentAssignment?> ReSubmitAnswerForStudentByQuestionId(int studentId, int questionId, int optionChosenId);
}