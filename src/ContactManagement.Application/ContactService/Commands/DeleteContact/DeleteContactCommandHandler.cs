using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Commands.DeleteContact
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, bool>
    {
        private readonly IContactRepository _contactRepository;

        public DeleteContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public async Task<bool> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
           var contact = await _contactRepository.GetByIdAsync(request.Id);

            if (contact == null) throw new Exception("Not Found Id");
            
            return  await _contactRepository.DeleteAsync(request.Id);
        }
    }
}
