using Microsoft.AspNetCore.Mvc;

namespace TextGram.Post;
[ApiController]
[Route("api/textgram")]
public class UserController: ControllerBase
{
    private readonly UserService _userService = new UserService();

    //-------------------HttpGet------------
    [HttpGet("get-user-by-id")]
    public ActionResult<User> GetUserById([FromHeader]int userId)
    {
        return _userService.GetUserById(userId)!;
    }
    [HttpGet("get-all-users")]
    public ActionResult<List<User>> GetAllUsers()
    {
        return _userService.GetAllUsers();
    }

    //--------------HttpPost-------------

    [HttpPost("add-new-user")]
    public ActionResult<User> AddNewUser([FromBody]User? user)
    {
        return _userService.AddNewUser(user);
    }

    //----------------HttpDelete---------
    [HttpDelete("delete-user-by-id")]
    public ActionResult<string> DeleteUserById([FromHeader]int userId)
    {
        return _userService.DeleteUserById(userId);
    }
    
    //---------------HttpPut---------------
    [HttpPut("update-user-by-id")]
    public ActionResult<string> UpdateUserById(int userId, User? user)
    {
        return _userService.UpdateUserById(userId, user);
    }
}