
using Microsoft.EntityFrameworkCore;
using User;

namespace TextGram.Data.Repositories;

public class AUserRepository
{
    private readonly TextGramDbContext _dbContext;

    public AUserRepository(TextGramDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<AUser>> GetUsersAsync()
    {
        return await _dbContext.Users.AsNoTracking().ToListAsync<AUser>();
    }

    public async Task<List<Post>> GetUserWithPotsAsync(long userId)
    {
        return await _dbContext.Posts
            .AsNoTracking()
            .Where(post => post.AuthorId == userId)
            .ToListAsync();
    }
    
    public async Task<List<Post>> GetUserWithPotsAsyncWay2(long userId)
    {
        var query = _dbContext.Posts.AsNoTracking();
        query = query.Where( post => post.AuthorId == userId);
        return await query.ToListAsync();
    }

    public async Task<List<AUser>> GetUserByIdAsync(long userId)
    {
        return await _dbContext.Users
            .AsNoTracking()
            .Where(user => user.UserId == userId)
            .ToListAsync();
    } 
    
    public async Task AddNewUserAsync(AUser newUser)
    {
        await _dbContext.Users.AddAsync(newUser);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(AUser updatedUser)
    {
        await _dbContext.Users
            .ExecuteUpdateAsync(s => s
                .SetProperty(u => u.UserId, updatedUser.UserId)
                .SetProperty(u => u.FirstName, updatedUser.FirstName)
                .SetProperty(u => u.LastName, updatedUser.LastName)
                .SetProperty(u => u.Email, updatedUser.Email)
                .SetProperty(u => u.UserState, updatedUser.UserState)
                .SetProperty(u => u.UserPassword, updatedUser.UserPassword)
                .SetProperty(u => u.UserLogin, updatedUser.UserLogin)
                .SetProperty(u => u.UserDescription, updatedUser.UserDescription)
            );
    }

    public async Task DeleteUserAsync(long userId)
    {
        await _dbContext.Users
            .Where(user => user.UserId == userId)
            .ExecuteDeleteAsync();
    }
}