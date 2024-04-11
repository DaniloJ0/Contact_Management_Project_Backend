using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.UserService.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
           var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null) throw new Exception("Not Found Id");
            
            return  await _userRepository.DeleteAsync(request.Id);
        }
    }
}
