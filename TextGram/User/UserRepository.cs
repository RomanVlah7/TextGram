namespace TextGram.User;

public class UserRepository
{
    private static Dictionary<int, Post.User> _users = new Dictionary<int, Post.User>();

    public Post.User? AddNewUser(Post.User? user)
    {
        _users.Add(user!.UserId, user);
        return user;
    }

    public Post.User? GetUserById(int userId)
    {
       return _users.GetValueOrDefault(userId);
    }

    public string DeleteUserById(int userId)
    {
        _users.Remove(userId);
        return "User deleted successfully";
    }

    public string UpdateUserById(int userId, Post.User? user)
    {
        _users[userId] = user;
        return "User updated successfully";
    }

    public List<Post.User?> GetAllUsers()
    {
        return _users.Values.ToList();
    }
}