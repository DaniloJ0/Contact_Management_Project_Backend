using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Commands.Update
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, bool>
    {
        private readonly IContactRepository _contactRepository;
        public UpdateContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<bool> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetByIdAsync(request.Id);

            if (contact == null)
            {
                throw new Exception("Not Found Contact Id");
            }

            var updatedContact = new Contact(
                request.Id,
                request.Name,
                request.Email,
                request.PhoneNumber,
                request.Address,
                request.Company,
                request.Note,
                request.UserId
            );


            return await _contactRepository.UpdateAsync(updatedContact);
        }
    }
}
