using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.SeedData;

public class StudentAssignmentConfiguration : IEntityTypeConfiguration<StudentAssignment>
{
    public void Configure(EntityTypeBuilder<StudentAssignment> builder)
    {
        builder.HasKey(e => new { e.QuestionId, e.StudentId });
        
        builder.HasOne(x => x.Question)
            .WithMany()
            .HasForeignKey(x => x.QuestionId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
        
        builder.HasOne(x => x.ChosenOption)
            .WithMany()
            .HasForeignKey(x => x.ChosenOptionId)
            .OnDelete(DeleteBehavior.Restrict) 
            .IsRequired();
        
        builder.HasData(
            new StudentAssignment()
            {
                StudentId = 1,
                QuestionId = 1,
                ChosenOptionId = 1,
                IsValid = false,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 1,
                QuestionId = 2,
                ChosenOptionId = 8,
                IsValid = false,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 1,
                QuestionId = 3,
                ChosenOptionId = 11,
                IsValid = true,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 1,
                QuestionId = 5,
                ChosenOptionId = 16,
                IsValid = false,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 1,
                QuestionId = 12,
                ChosenOptionId = 19,
                IsValid = false,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 2,
                QuestionId = 1,
                ChosenOptionId = 2,
                IsValid = true,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 2,
                QuestionId = 2,
                ChosenOptionId = 8,
                IsValid = false,
                AnswerFeedback = ""
            },
            new StudentAssignment()
            {
                StudentId = 2,
                QuestionId = 3,
                ChosenOptionId = 12,
                IsValid = false,
                AnswerFeedback = ""
            });
    }
}