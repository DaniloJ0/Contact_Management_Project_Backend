using ContactManagement.Application.UserService.Queries.GetUsers;
using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserQuery>
    {
        public UserId Id { get; set; }
    }
}
