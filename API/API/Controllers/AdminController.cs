using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AdminController : BaseApiController
    {
        private readonly UserManager<AppUser> _userManager;
        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize(Policy = "RequiredModerator")]
        [HttpGet("admin_moderator_role")]
        public async Task<ActionResult> GetUsersWithRoles()
        {
            var users = await _userManager.Users
                    .Include(r => r.UserRoles)
                    .ThenInclude(r => r.Role)
                    .OrderBy(u => u.UserName)
                    .Select(user => new
                    {
                        user.Id,
                        Username = user.UserName,
                        Roles = user.UserRoles.Select(role => role.Role.Name).ToList()
                    })
                    .ToListAsync();

            return Ok(users);
        }

        [Authorize(Policy = "RequiredAdmin")]
        [HttpPut("edit_roles/{username}")]
        public async Task<ActionResult> GetUsersWithRoles(string username, [FromQuery] string roles)
        {
            if (string.IsNullOrEmpty(roles)) 
            {
                return BadRequest("Please select at least one role");
            }

            var selectedRoles = roles.Split(',').ToArray();

            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return NotFound("Could not find user");
            }

            var userRoles = await _userManager.GetRolesAsync(user);

            var result = await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles));

            if (!result.Succeeded) 
            {
                return BadRequest("Failed to add to roles");
            }

            result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles));

            if (!result.Succeeded)
            {
                return BadRequest("Failed to remove from roles");
            }

            return Ok();
        }

    }
}
