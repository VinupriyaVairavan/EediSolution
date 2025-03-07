using API.Dto;
using API.Dtos;
using API.Entities;
using AutoMapper;

namespace API.Profiler;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<QuestionOption, QuestionOptionDto>()
            .ForMember(st => st.QuestionOptionId, src => 
                src.MapFrom(s => s.Id));
        CreateMap<Question, QuestionDto>()
            .ForMember(st => st.QuestionId, src => 
                src.MapFrom(s => s.Id))
            .ForMember(st => st.ChosenOptions, src => 
                src.MapFrom(s => s.Options));
        CreateMap<StudentAssignment, StudentAssignmentDto>();
        CreateMap<Student, StudentDto>()
            .ForMember(st => st.StudentId, src => 
                src.MapFrom(s => s.Id));
        CreateMap<SubTopic, SubTopicDto>()
            .ForMember(st => st.SubTopicId, src =>
                src.MapFrom(s => s.Id))
            .ForMember(st => st.MisconceptionCount, src =>
                src.MapFrom(s => s.Questions.Count()))
            .ForMember(st => st.SubTopicTitle, src =>
                src.MapFrom(s => s.Name));
        CreateMap<Topic, TopicDto>()
            .ForMember(st => st.TopicId, src => 
                src.MapFrom(s => s.Id))
            .ForMember(st => st.TopicName, src => 
                src.MapFrom(s => s.Name));
    }
}