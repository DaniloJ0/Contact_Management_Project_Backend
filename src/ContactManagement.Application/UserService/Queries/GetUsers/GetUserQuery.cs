using MediatR;

namespace ContactManagement.Application.UserService.Queries.GetUsers
{
    public class GetUserQuery : IRequest<List<UserQuery>>
    {

    }


}
