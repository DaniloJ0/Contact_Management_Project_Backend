using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public UserId Id { get; set; }
    }
}
