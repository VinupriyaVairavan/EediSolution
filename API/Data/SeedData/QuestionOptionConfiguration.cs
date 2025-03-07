using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.SeedData;

public class QuestionOptionConfiguration : IEntityTypeConfiguration<QuestionOption>
{
    public void Configure(EntityTypeBuilder<QuestionOption> builder)
    {
        builder.HasKey(qo => qo.Id);

        builder.HasData(
            new QuestionOption
            {
                Id = 1,
                QuestionId = 1,
                Label = "A",
                Description = "I think you have counted down rather than up. You can use a number line to help you.",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 2,
                QuestionId = 1,
                Label = "B",
                Description = "The correct sequence is \n -16, -13, -10, -7, -4",
                IsCorrectOption = true
            },
            new QuestionOption
            {
                Id = 3,
                QuestionId = 1,
                Label = "C",
                Description = "Incorrect due to...",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 4,
                QuestionId = 1,
                Label = "D",
                Description = "It's a wrong answer",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 5,
                QuestionId = 2,
                Label = "A",
                Description = "I think you have counted down rather than up. You can use a number line to help you.",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 6,
                QuestionId = 2,
                Label = "B",
                Description = "Incorrect due to...",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 7,
                QuestionId = 2,
                Label = "C",
                Description = "The correct sequence is \n -16, -13, -10, -7, -4",
                IsCorrectOption = true
            },
            new QuestionOption
            {
                Id = 8,
                QuestionId = 2,
                Label = "D",
                Description = "It's a wrong answer",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 9,
                QuestionId = 3,
                Label = "A",
                Description = "I think you have counted down rather than up. You can use a number line to help you.",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 10,
                QuestionId = 3,
                Label = "B",
                Description = "Incorrect due to...",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 11,
                QuestionId = 3,
                Label = "C",
                Description = "The correct sequence is \n -16, -13, -10, -7, -4",
                IsCorrectOption = true
            },
            new QuestionOption
            {
                Id = 12,
                QuestionId = 3,
                Label = "D",
                Description = "It's a wrong answer",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 13,
                QuestionId = 5,
                Label = "A",
                Description = "I think you have counted down rather than up. You can use a number line to help you.",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 14,
                QuestionId = 5,
                Label = "B",
                Description = "Incorrect due to...",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 15,
                QuestionId = 5,
                Label = "C",
                Description = "The correct sequence is \n -16, -13, -10, -7, -4",
                IsCorrectOption = true
            },
            new QuestionOption
            {
                Id = 16,
                QuestionId = 5,
                Label = "D",
                Description = "It's a wrong answer",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 17,
                QuestionId = 12,
                Label = "A",
                Description = "I think you have counted down rather than up. You can use a number line to help you.",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 18,
                QuestionId = 12,
                Label = "B",
                Description = "Incorrect due to...",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 19,
                QuestionId = 12,
                Label = "C",
                Description = "Try Again",
                IsCorrectOption = false
            },
            new QuestionOption
            {
                Id = 20,
                QuestionId = 12,
                Label = "D",
                Description = "Correct",
                IsCorrectOption = true
            }
        );
    }
}
