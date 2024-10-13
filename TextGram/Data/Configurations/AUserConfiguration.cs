using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TextGram.Data.Configurations;

public class AUserConfiguration : IEntityTypeConfiguration<AUser>
{
    public void Configure(EntityTypeBuilder<AUser> builder)
    {
        builder.HasKey(a => a.UserId);
        builder.HasMany(typeof(Post));
        
        builder.Property(a => a.Email).IsRequired();
        builder.Property(a => a.FirstName).IsRequired();
        builder.Property(a => a.UserLogin).IsRequired();
        builder.Property(a => a.UserPassword).IsRequired();
        builder.Property(a => a.UserDescription);
    }


}