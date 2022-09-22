using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = OD.Data.Models.File;

namespace OD.Data.Map;

public class FileMap : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.HasKey(x => x.Id);
        builder
            .HasOne(x => x.Publication)
            .WithMany(x => x.Files)
            .HasForeignKey(x => x.PublicationId);

        builder
            .HasOne(x => x.Review)
            .WithMany(x => x.Files)
            .HasForeignKey(x => x.ReviewId)
            .IsRequired(false);
    }
}