using ContactManagement.Application.ContactService.Commands.CreateContact;
using ContactManagement.Application.UserService.Commands.CreateUser;
using ContactManagement.Application.UserService.Commands.DeleteUser;
using ContactManagement.Application.UserService.Commands.Update;
using ContactManagement.Application.UserService.Queries.GetUserById;
using ContactManagement.Application.UserService.Queries.GetUsers;
using ContactManagement.Domain.Users;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
       private readonly ISender _mediator;
        private readonly IValidator<CreateUserCommand> _validator;

        public UserController(ISender mediator, IValidator<CreateUserCommand> validator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _validator = validator;
        }

        [HttpGet("GetUsers")]
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
            var validationResult = _validator.Validate(command);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var user = await _mediator.Send(command);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser([FromBody] UserId id)
        {
            var user = await _mediator.Send(new DeleteUserCommand { Id = id });
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
        
    }
}
