using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace TextGram.Data.Repositories;

public class PostRepository(TextGramDbContext dbContext)
{
    public async Task<List<Post>> GetAllPostsAsync()
    {
        return await dbContext.Posts.AsNoTracking().ToListAsync();
    }

    public async Task<List<Post>> GetPostAsync(long postId)
    {
        return await dbContext.Posts
            .AsNoTracking()
            .Where(post => post.PostId == postId)
            .ToListAsync();
    }

    public async Task AddNewPostAsync(Post post)
    {
        await dbContext.Posts.AddAsync(post);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdatePostAsync(Post updatedPost)
    {
        await dbContext.Posts
            .ExecuteUpdateAsync(s => s
                .SetProperty(x => x.PostId, updatedPost.PostId)
                .SetProperty(x => x.TextOfPost, updatedPost.TextOfPost)
                .SetProperty(x => x.AuthorId, updatedPost.AuthorId)
            );
    }

    public async Task DeletePostAsync(long postId)
    {
        await dbContext.Posts
            .Where( p => p.PostId == postId)
            .ExecuteDeleteAsync();
    }
}