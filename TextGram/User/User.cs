namespace TextGram.Post;

public class User
{
    private string _username;
    private int _userId;

    public User(string username, int userId)
    {
        _username = username;
        _userId = userId;
    }

    public string Username
    {
        get => _username;
        set => _username = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int UserId
    {
        get => _userId;
        set => _userId = value;
    }
    
}