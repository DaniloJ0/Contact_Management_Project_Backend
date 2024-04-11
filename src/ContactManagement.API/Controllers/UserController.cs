using ContactManagement.Application.UserService.Commands.CreateUser;
using ContactManagement.Application.UserService.Queries.GetUserById;
using ContactManagement.Application.UserService.Queries.GetUsers;
using ContactManagement.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
       private readonly ISender _mediator;

        public UserController(ISender mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _mediator.Send(new GetUserQuery());
            return Ok(users);
        }

        [HttpGet("GetById")]
        public async Task<ActionResult> GetUserById([FromBody] UserId id)
        {
            var user = await _mediator.Send(new GetUserByIdQuery { Id = id });
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
        
        
    }
}
