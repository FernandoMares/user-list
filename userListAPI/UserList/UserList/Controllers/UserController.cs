// Controllers/UserController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UserList.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Simulación de una base de datos en memoria
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Fernando García Mares", Email = "fernandoo.g.mares@gmail.com" },
            new User { Id = 2, Name = "David Mares", Email = "davidmares@gmail.com" }
        };

        [HttpGet("getUsers")]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        [HttpPost("addUser")]
        public IActionResult AddUser([FromBody] User newUser)
        {
            if (newUser == null)
            {
                return BadRequest("Invalid user data.");
            }

            // Generate ID
            newUser.Id = users.Max(u => u.Id) + 1;
            users.Add(newUser);

            return Ok(newUser);
        }
    }
}
