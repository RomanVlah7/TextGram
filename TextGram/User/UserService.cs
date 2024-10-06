using TextGram.User;

namespace TextGram.Post;

public class UserService
{
    private readonly UserRepository _userRepository = new UserRepository();
    
    public User? AddNewUser(User? user)
    {
        return _userRepository.AddNewUser(user);
    }

    public User? GetUserById(int userId)
    {
        return _userRepository.GetUserById(userId);
    }

    public string DeleteUserById(int userId)
    {
        return _userRepository.DeleteUserById(userId);
    }

    public string UpdateUserById(int userId, User? user)
    {
        return _userRepository.UpdateUserById(userId, user);
    }

    public List<User?> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }
}