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
    public async Task<ActionResult<AUser>> GetUserById([FromHeader]int userId)
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
        return userService.GetAllUsersAsync();
    }

    //--------------HttpPost-------------

    [HttpPost("add-new-user")]
    public ActionResult<AUser> AddNewUser([FromBody]AUser? user)
    {
        return userService.AddNewUserAsync(user);
    }

    //----------------HttpDelete---------
    [HttpDelete("delete-user-by-id")]
    public ActionResult<string> DeleteUserById([FromHeader]int userId)
    {
        return userService.DeleteUserByIdAsync(userId);
    }
    
    //---------------HttpPut---------------
    [HttpPut("update-user-by-id")]
    public ActionResult<string> UpdateUserById(int userId, AUser? user)
    {
        return userService.UpdateUserByIdAsync(userId, user);
    }
}