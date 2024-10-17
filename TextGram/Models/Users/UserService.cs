using TextGram.Data.Repositories;

namespace User;

public class UserService(AUserRepository userRepository)
{
    public async Task AddNewUserAsync(AUser user)
    {
        await userRepository.AddNewUserAsync(user);
    }

    public Task<List<AUser>> GetUserByIdAsync(long userId)
    {
        return userRepository.GetUserByIdAsync(userId);
    }

    public async Task DeleteUserByIdAsync(long userId)
    {
        await userRepository.DeleteUserAsync(userId);
        
    }

    public async Task UpdateUserByIdAsync(AUser user)
    {
        await userRepository.UpdateUserAsync(user);
    }

    public List<AUser> GetAllUsers()
    {
        return userRepository.GetUsersAsync().Result;
    }
}