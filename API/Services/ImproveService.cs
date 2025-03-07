using API.Dto;
using API.Dtos;
using API.Entities;
using API.Exceptions;
using API.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class ImproveService(IRepositoryManager repositoryManager, IMapper mapper) : IImproveService
{
    public async Task<IEnumerable<TopicDto>> GetMisConceptionsForStudent(int studentId)
    {
        await CheckStudentValidityAsync(studentId);
        
        var misconceptionTopics = 
           await repositoryManager.StudentRepository.GetMisconceptionTopicsByStudentId(studentId);

        var response = mapper.Map<List<Topic>, List<TopicDto>>(misconceptionTopics);
        
        return response;
    }

    public async Task<SubTopicDto> GetMisConceptionsForStudentBySubTopicId(int studentId, int subTopicId)
    {
        await CheckStudentValidityAsync(studentId);
        
        var subTopic =
            await repositoryManager.QuestionRepository.GetSubTopicByIdAsync(subTopicId);
        
        if(subTopic is null)
            throw new SubTopicNotFoundException(subTopicId);
        
        var misconceptionSubTopics = 
            await repositoryManager.StudentRepository.GetMisConceptionsForStudentBySubTopicId(studentId, subTopicId);
        
        if(misconceptionSubTopics is null)
            throw new NotFoundException("Question was never answered before by the student before!");

        var response = mapper.Map<SubTopic, SubTopicDto>(misconceptionSubTopics);
        
        return response;
    }

    public async Task<StudentAssignmentDto> ReSubmitAnswerForStudentByQuestionId(int studentId, int questionId, int optionChosenId)
    {
        await CheckStudentValidityAsync(studentId);
        
        var question =
            await repositoryManager.QuestionRepository.GetQuestionByIdAsync(questionId);
        
        if(question is null)
            throw new NotFoundException($"Question with id: {questionId} not found!");
        
        var reSubmittedAnswer =
            await repositoryManager
                .StudentRepository
                .ReSubmitAnswerForStudentByQuestionId(studentId, questionId, optionChosenId);
        
        if(reSubmittedAnswer is null)
            throw new NotFoundException("Question was never answered before or chosen option is not valid!");
        
        var response = mapper.Map<StudentAssignment, StudentAssignmentDto>(reSubmittedAnswer);
        
        repositoryManager.Save();
        
        return response;
    }

    private async Task CheckStudentValidityAsync(int studentId)
    {
        var student = 
            await repositoryManager.StudentRepository.GetStudentById(studentId);
        
        if(student == null)
            throw new StudentNotFoundException(studentId);
    }
}