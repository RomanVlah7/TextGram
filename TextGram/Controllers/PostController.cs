using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace User;
[ApiController]
[Route("api/textgram")]
public class PostController(PostService postService): ControllerBase
{
    //---------------Http Get--------------
    [HttpGet("get-post-by-id")]
    public async Task<ActionResult<Post>> GetPostByIdAsync([FromQuery]long postId)
    {
        var post = await postService.GetPostAsync(postId);
    
        if (post.IsNullOrEmpty())
        {
            return NotFound("Post not found");
        }

        return Ok(post);
    }

    [HttpGet("get-all-posts")]
    public async Task<List<Post>> GetAllPosts()
    {
       return await postService.GetAllPostsAsync(); 
    }
    
    //---------------Http Post-----------------
    [HttpPost("add-new-post")]
    public async Task AddNewPostAsync([FromBody] Post post)
    {
        await postService.AddNewPostAsync(post);
    }
    
    //----------------Http Patch----------------
    [HttpPatch("update-post")]
    public async Task UpdatePostAsync([FromBody] Post post)
    {
        await postService.UpdatePostAsync(post);
    }
    
    //----------------Http Delete-------------
    [HttpDelete("delete-post")]
    public async Task DeletePostAsync(long postId)
    {
        await postService.DeletePostAsync(postId);
    }
}