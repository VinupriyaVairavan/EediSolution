using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.SeedData;

public class QuestionsConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasData(
            new Question()
            {
                Id = 1,
                ImageUrl = "images/questions11.jpg",
                SubTopicId = 1
            },
            new Question()
            {
                Id = 2,
                ImageUrl = "images/questions12.jpg",
                SubTopicId = 1
            },
            new Question()
            {
                Id = 3,
                ImageUrl = "images/questions13.jpg",
                SubTopicId = 1
            },
            new Question()
            {
                Id = 4,
                ImageUrl = "images/questions14.jpg",
                SubTopicId = 1
            },
            new Question()
            {
                Id = 5,
                ImageUrl = "images/questions25.jpg",
                SubTopicId = 2
            },
            new Question()
            {
                Id = 6,
                ImageUrl = "images/questions26.jpg",
                SubTopicId = 2
            },
            new Question()
            {
                Id = 7,
                ImageUrl = "images/questions27.jpg",
                SubTopicId = 2
            },
            new Question()
            {
                Id = 8,
                ImageUrl = "images/questions28.jpg",
                SubTopicId = 2
            },
            new Question()
            {
                Id = 9,
                ImageUrl = "images/questions39.jpg",
                SubTopicId = 3
            },
            new Question()
            {
                Id = 10,
                ImageUrl = "images/questions410.jpg",
                SubTopicId = 4
            },
            new Question()
            {
                Id = 11,
                ImageUrl = "images/questions511.jpg",
                SubTopicId = 5
            },
            new Question()
            {
                Id = 12,
                ImageUrl = "images/questions612.jpg",
                SubTopicId = 6
            }
        );
    }
}