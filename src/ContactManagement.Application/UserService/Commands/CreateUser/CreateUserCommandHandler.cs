using ContactManagement.Application.UserService.Queries.GetUsers;
using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserQuery>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserQuery> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var createdUser = new User(
                new UserId(Guid.NewGuid()) 
                ,request.Name,
                request.Email
                );

            await _userRepository.AddAsync(createdUser);

            return new UserQuery
            {
                Id = createdUser.Id,
                Name = createdUser.Name,
                Email = createdUser.Email,
            };
        }
    }
}
