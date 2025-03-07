using API.Data.SeedData;
using API.Entities;
using API.MiddlewareExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Data;

public class AssignmentDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionOption> QuestionOptions { get; set; }
    public DbSet<Student?> Students { get; set; }
    public DbSet<StudentAssignment> StudentAssignments { get; set; }
    public DbSet<SubTopic> SubTopics { get; set; }
    public DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new TopicConfiguration());
        modelBuilder.ApplyConfiguration(new SubTopicConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionsConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionOptionConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new StudentAssignmentConfiguration());
    }
}