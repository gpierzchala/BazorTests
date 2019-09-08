namespace BazorTests.Server.Controllers
{
    using BazorTests.Server.Managers.Abstract;
    using BazorTests.Shared.DTOs;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private IUserManager _userManager { get; set; }

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = await _userManager.GetUsersAsync();
            return users;
        }

        [HttpGet("{Id}")]
        public async Task<UserDto> GetUser(int Id)
        {
            var user = await _userManager.GetUserAsync(Id);
            return user;
        }

        [HttpPost]
        public async Task<UserDto> CreateUser(UserDto user)
        {
            var newUser = await _userManager.CreateUserAsync(user);
            return newUser;
        }
    }
}
