using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.SeedData;

public class SubTopicConfiguration : IEntityTypeConfiguration<SubTopic>
{
    public void Configure(EntityTypeBuilder<SubTopic> builder)
    {
        builder.HasData(
            new SubTopic()
            {
                Id = 1,
                Name = "Fraction",
                TopicId = 1
            },
            new SubTopic()
            {
                Id = 2,
                Name = "Decimals",
                TopicId = 1
            },
            new SubTopic()
            {
                Id = 3,
                Name = "Factors",
                TopicId = 1
            },
            new SubTopic()
            {
                Id = 4,
                Name = "Multiples",
                TopicId = 2
            },
            new SubTopic()
            {
                Id = 5,
                Name = "Primes",
                TopicId = 2
            },
            new SubTopic()
            {
                Id = 6,
                Name = "Fractions",
                TopicId = 2
            }
        );
    }
}