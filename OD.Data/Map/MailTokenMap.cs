using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OD.Data.Models;

namespace OD.Data.Map;

public class MailTokenMap : IEntityTypeConfiguration<MailToken>
{
    public void Configure(EntityTypeBuilder<MailToken> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.User)
            .WithMany(x => x.Tokens)
            .HasForeignKey(x => x.UserId);
    }
}