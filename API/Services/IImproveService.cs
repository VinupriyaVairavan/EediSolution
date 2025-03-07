using System.Collections;
using API.Dto;
using API.Dtos;

namespace API.Services;

public interface IImproveService
{
    Task<IEnumerable<TopicDto>> GetMisConceptionsForStudent(int studentId);
    
    Task<SubTopicDto> GetMisConceptionsForStudentBySubTopicId(int studentId, int subTopicId);
    
    Task<StudentAssignmentDto> ReSubmitAnswerForStudentByQuestionId(int studentId, int questionId, int optionChosenId);
}