namespace API.Repositories;

public interface IRepositoryManager
{
    IStudentRepository StudentRepository { get; }
    IQuestionRepository QuestionRepository { get; }
    void Save();
}