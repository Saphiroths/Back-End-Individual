    using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Back_End.Logic;
using User_Back_End.ViewModels;

namespace User_Back_End.Controllers
{
    [Route("users")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly UserLogic _userLogic;
        public UserController(UserLogic userlogic)
        {
            _userLogic = userlogic;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<UserViewModel>> Login([FromBody] UserViewModel user)
        {
            user = _userLogic.GetUser(user);
            if (user != null)
            {
                return Ok(user);
            }
            return StatusCode(404, "User doesn't exist");
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<UserViewModel>> CreateUser([FromBody] UserViewModel user)
        {
            if (user.Username != null && user.Email != null && user.Address != null && user.City != null)
            {
                _userLogic.NewUser(user);
                return CreatedAtAction("CreateUser", user);
            }
            return StatusCode(404, "Not all fields are filled in");
        }

    }
}
