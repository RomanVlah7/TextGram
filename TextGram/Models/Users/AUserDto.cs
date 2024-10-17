namespace User;

public class AUserDto
{
    private int _userId;
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _userState;
    private string _userDescription;

    public AUserDto(int userId, string firstName, string lastName, string email, string userState)
    {
        _userId = userId;
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _userState = userState;
    }

    public int UserId
    {
        get => _userId;
        set => _userId = value;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Email
    {
        get => _email;
        set => _email = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string UserState
    {
        get => _userState;
        set => _userState = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string UserDescription
    {
        get => _userDescription;
        set => _userDescription = value ?? throw new ArgumentNullException(nameof(value));
    }
}