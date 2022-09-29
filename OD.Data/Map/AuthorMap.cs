using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OD.Data.Models;

namespace OD.Data.Map;
//конфигуратор
public class AuthorMap : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Department)
            .WithMany(x => x.Authors)
            .HasForeignKey(x => x.DepartmentId)
            .IsRequired(false);
    }
}