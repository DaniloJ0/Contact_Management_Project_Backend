using ContactManagement.Domain.Users;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //[HttpGet("GetAllUsers")]
        //public async Task<IActionResult> GetAllUsersAsync()
        //{
            
        //}
        
        
    }
}
