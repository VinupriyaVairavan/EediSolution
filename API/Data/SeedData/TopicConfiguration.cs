using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.SeedData;

public class TopicConfiguration : IEntityTypeConfiguration<Topic>
{
    public void Configure(EntityTypeBuilder<Topic> builder)
    {
        builder.HasData(
            new Topic()
            {
                Id = 1,
                Name = "Number"
            },
            new Topic()
            {
                Id = 2,
                Name = "Algebra"
            }
        );
    }
}