using API.Data;

namespace API.Repositories;

public class RepositoryManager(AssignmentDbContext context) : IRepositoryManager
{
    private readonly Lazy<IStudentRepository> _studentRepository = new(() => new StudentRepository(context));
    private readonly Lazy<IQuestionRepository> _questionRepository = new(() => new QuestionRepository(context));

    public IStudentRepository StudentRepository => _studentRepository.Value;
    public IQuestionRepository QuestionRepository => _questionRepository.Value;

    public void Save() => context.SaveChanges();
}