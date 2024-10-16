﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TextGram.Data.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(a => a.PostId);
        builder.Property(a => a.TextOfPost).IsRequired();
        builder.Property(a => a.AuthorId).IsRequired();
        builder.HasOne<AUser>()
            .WithMany()
            .HasForeignKey(p => p.AuthorId);
    }
}