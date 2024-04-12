using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Queries.GetContactsByUserId
{
    public class GetContactsByUserIdQueryHandler : IRequestHandler<GetContactsByUserIdQuery, List<ContactQuery>>
    {
        private readonly IContactRepository _ContactRepository;

        public GetContactsByUserIdQueryHandler(IContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        public async Task<List<ContactQuery>> Handle(GetContactsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var ContactRequest = await _ContactRepository.GetByUserIdAsync(request.Id);

            var Contact = new List<ContactQuery>();

            foreach (var contact in ContactRequest)
            {
                var ContactTemp = new ContactQuery
                {
                    Id = contact.Id,
                    Name = contact.Name,
                    Email = contact.Email,
                    PhoneNumber = contact.PhoneNumber,
                    Address = contact.Address,
                    Company = contact.Company,
                    Note = contact.Note,
                    UserId = contact.UserId
                };

                Contact.Add(ContactTemp);
            }

            return Contact;
        }
    }
}
