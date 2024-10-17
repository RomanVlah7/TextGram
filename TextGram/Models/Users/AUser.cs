using System.ComponentModel.DataAnnotations;

public class AUser(
    long userId,
    string firstName,
    string lastName,
    string email,
    string userState,
    string userPassword,
    string userLogin,
    string userDescription)
{
    [Key] private long _userId = userId;
    private string _firstName = firstName;
    private string _lastName = lastName;
    private string _email = email;
    private string _userState = userState;
    private string _userPassword = userPassword;
    private string _userLogin = userLogin;
    private string _userDescription = userDescription;

 

    public string UserDescription
    {
        get => _userDescription;
        set => _userDescription = value ?? throw new ArgumentNullException(nameof(value));
    }

    public long UserId
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