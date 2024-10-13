using System.ComponentModel.DataAnnotations;

public class AUser
{
    [Key] private int _userId;
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _userState;
    private string _userPassword;
    private string _userLogin;
    private string _userDescription;

    public AUser(int userId, string firstName, string lastName, string email, string userState, string userPassword, string userLogin)
    {
        _userId = userId;
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _userState = userState;
        _userPassword = userPassword;
        _userLogin = userLogin;
    }

    public string UserDescription
    {
        get => _userDescription;
        set => _userDescription = value ?? throw new ArgumentNullException(nameof(value));
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

    public string UserPassword
    {
        get => _userPassword;
        set => _userPassword = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string UserLogin
    {
        get => _userLogin;
        set => _userLogin = value ?? throw new ArgumentNullException(nameof(value));
    }
}