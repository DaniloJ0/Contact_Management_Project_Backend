using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Commands.Update
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new Exception("Not Found Id");
            }

            var updatedUser = new User(
                request.Id,
                request.Name,
                request.Email,
                request.Password
            );

            
           return await _userRepository.UpdateAsync(updatedUser);
        }
    }
}
