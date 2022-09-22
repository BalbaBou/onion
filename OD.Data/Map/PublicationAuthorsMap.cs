using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OD.Data.Models;

namespace OD.Data.Map;

public class PublicationAuthorsMap : IEntityTypeConfiguration<PublicationAuthors>
{
    public void Configure(EntityTypeBuilder<PublicationAuthors> builder)
    {
        builder.HasKey(x => new {x.AuthorId, x.PublicationId});

        builder
            .HasOne(x => x.Author)
            .WithMany(x => x.Publications)
            .HasForeignKey(x => x.AuthorId)
            .IsRequired(true);

        builder
            .HasOne(x => x.Publication)
            .WithMany(x => x.Authors)
            .HasForeignKey(x => x.PublicationId)
            .IsRequired(true);
    }
}