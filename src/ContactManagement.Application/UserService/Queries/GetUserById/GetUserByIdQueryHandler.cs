using ContactManagement.Application.UserService.Queries.GetUsers;
using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserQuery>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserQuery> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var userRequest = await _userRepository.GetByIdAsync(request.Id);

            var user = new UserQuery
            {
                Id = userRequest.Id,
                Name = userRequest.Name,
                Email = userRequest.Email,
            };

            return user;
        }
    }
}
