using ContactManagement.Application.UserService.Queries.GetUsers;
using MediatR;

namespace ContactManagement.Application.UserService.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<UserQuery>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
