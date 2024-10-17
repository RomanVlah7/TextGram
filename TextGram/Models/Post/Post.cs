
using System.ComponentModel.DataAnnotations;
using User;

public class Post
{
    [Key]private long _postId;
    private string _textOfPost;
    private long _authorId;

    public Post(long postId, string textOfPost, long authorId)
    {
        _postId = postId;
        _textOfPost = textOfPost;
        _authorId = authorId;
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

    public long AuthorId
    {
        get => _authorId;
        set => _authorId = value;
    }
}