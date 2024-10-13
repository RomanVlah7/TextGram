using TextGram.Data.Repositories;

namespace User;

public class UserService(AUserRepository userRepository)
{
    public async Task AddNewUserAsync(AUser user)
    {
        await userRepository.AddNewUserAsync(user);
    }

    public Task<List<AUser>> GetUserByIdAsync(int userId)
    {
        return userRepository.GetUserByIdAsync(userId);
    }

    public async Task DeleteUserByIdAsync(int userId)
    {
        await userRepository.DeleteUserAsync(userId);
        
    }

    public async Task UpdateUserByIdAsync(AUser user)
    {
        await userRepository.UpdateUserAsync(user);
    }

    public List<AUser> GetAllUsersAsync()
    {
        return userRepository.GetUsersAsync().Result;
    }
}