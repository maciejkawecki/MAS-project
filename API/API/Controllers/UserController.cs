using API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class UserController : BaseApiController
    {
        //private readonly
        //public UserController() 
        //{ 

        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountDto>>> GetUsers()
        {
            return Ok();
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<AccountDto>> GetUser(string username)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser()
        {
            return Ok();
        }


    }
}
