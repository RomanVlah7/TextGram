using Microsoft.EntityFrameworkCore;
using TextGram.Data.Configurations;


public class TextGramDbContext : DbContext
{
    public TextGramDbContext(DbContextOptions<TextGramDbContext> options) : base(options)
    {
    }
    public DbSet<AUser> Users { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AUserConfiguration());
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        base.OnModelCreating(modelBuilder);
    }
    
}