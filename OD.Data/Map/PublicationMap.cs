using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OD.Data.Models;

namespace OD.Data.Map;

public class PublicationMap : IEntityTypeConfiguration<Publication>
{
    public void Configure(EntityTypeBuilder<Publication> builder)
    {
        builder.HasKey(x => x.Id);
        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Publications)
            .HasForeignKey(x => x.UserId);

        builder
            .HasOne(x => x.Reviewer)
            .WithMany(x => x.Publications)
            .HasForeignKey(x => x.ReviewerId)
            .IsRequired(false);
    }
}