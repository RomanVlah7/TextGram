using TextGram.Data.Repositories;

namespace User;

public class PostService(PostRepository postRepository)
{
    public async Task<List<Post>> GetAllPostsAsync()
    {
        return await postRepository.GetAllPostsAsync();
    }

    public async Task<List<Post>> GetPostAsync(long postId)
    {
        return await postRepository.GetPostAsync(postId);
    }

    public async Task DeletePostAsync(long postId)
    {
        await postRepository.DeletePostAsync(postId);
    }

    public async Task UpdatePostAsync(Post post)
    {
        await postRepository.UpdatePostAsync(post);
    }

    public async Task AddNewPostAsync(Post post)
    {
        await postRepository.AddNewPostAsync(post);
    }
}