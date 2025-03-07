using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.SeedData;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasData(
            new Student()
            {
                Id = 1,
                Name = "John Doe"
            },
            new Student()
            {
                Id = 2,
                Name = "Jane Smith"
            },
            new Student()
            {
                Id = 3,
                Name = "Lilly Vernon"
            }
        );
    }
}