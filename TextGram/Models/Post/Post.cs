
using System.ComponentModel.DataAnnotations;
using User;

public class Post
{
    [Key]private long _postId;
    private string _textOfPost;
    private AUserDto _author;

    public Post(long postId, string textOfPost, AUserDto author)
    {
        _postId = postId;
        _textOfPost = textOfPost;
        _author = author;
    }

    

    public long PostId
    {
        get => _postId;
        set => _postId = value;
    }

    public string TextOfPost
    {
        get => _textOfPost;
        set => _textOfPost = value ?? throw new ArgumentNullException(nameof(value));
    }

    public AUserDto Author
    {
        get => _author;
        set => _author = value ?? throw new ArgumentNullException(nameof(value));
    }
}