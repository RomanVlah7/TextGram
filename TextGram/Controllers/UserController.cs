using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using User;

namespace TextGram.Controllers;
[ApiController]
[Route("api/textgram")]
public class UserController(UserService userService) : ControllerBase
{
    //-------------------HttpGet------------
    [HttpGet("get-user-by-id")]
    public async Task<ActionResult<AUser>> GetUserById([FromHeader]long userId)
    {
        var user = await userService.GetUserByIdAsync(userId);
    
        if (user.IsNullOrEmpty())
        {
            return NotFound();
        }
        
        return Ok(user);
    }
    
    [HttpGet("get-all-users")]
    public ActionResult<List<AUser>> GetAllUsers()
    {
        return userService.GetAllUsers();
    }

    //--------------HttpPost-------------
    [HttpPost("add-new-user")]
    public async Task AddNewUser([FromBody]AUser user)
    {
        await userService.AddNewUserAsync(user);
    }

    //----------------HttpDelete---------
    [HttpDelete("delete-user-by-id")]
    public Task DeleteUserById([FromHeader]long userId)
    {
        return userService.DeleteUserByIdAsync(userId);
    }
    
    //---------------HttpPut---------------
    [HttpPut("update-user-by-id")]
    public async Task UpdateUserById([FromBody] AUser user)
    { 
        await userService.UpdateUserByIdAsync(user);
    }
}