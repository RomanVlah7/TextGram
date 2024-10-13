using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace TextGram.Data.Repositories;

public class PostRepository
{
    private readonly TextGramDbContext _dbContext;

    public PostRepository(TextGramDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Post>> GetPostsAsync()
    {
        return await _dbContext.Posts.AsNoTracking().ToListAsync();
    }

    public async Task<List<Post>> GetPostAsync(int postId)
    {
        return await _dbContext.Posts
            .Where(post => post.PostId == postId)
            .ToListAsync();
    }

    public async Task AddNewPostAsync(Post post)
    {
        await _dbContext.Posts.AddAsync(post);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdatePostAsync(Post updatedPost)
    {
        await _dbContext.Posts
            .ExecuteUpdateAsync(s => s
                .SetProperty(x => x.PostId, updatedPost.PostId)
                .SetProperty(x => x.TextOfPost, updatedPost.TextOfPost)
                .SetProperty(x => x.Author, updatedPost.Author)
            );
    }

    public async Task DeletePostAsync(int postId)
    {
        await _dbContext.Posts
            .Where( p => p.PostId == postId)
            .ExecuteDeleteAsync();
    }
}