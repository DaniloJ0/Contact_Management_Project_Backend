using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Commands.Update
{
    public class UpdateUserCommand : IRequest<bool>
    {
        public UserId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
