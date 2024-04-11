using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Queries.GetUsers
{
    public class GetUSerQueryHandler : IRequestHandler<GetUserQuery, List<UserQuery>>
    {

        private readonly IUserRepository _userRepository;

        public GetUSerQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserQuery>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync();
            var userList = users.Select(x => new UserQuery
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
            }).ToList();

            return userList;
        }
    }
}
