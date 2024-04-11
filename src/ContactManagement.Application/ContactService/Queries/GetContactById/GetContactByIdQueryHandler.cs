using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Queries.GetContactById
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, ContactQuery>
    {
        private readonly IContactRepository _ContactRepository;

        public GetContactByIdQueryHandler(IContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        public async Task<ContactQuery> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var ContactRequest = await _ContactRepository.GetByIdAsync(request.Id);

            var Contact = new ContactQuery
            {
                Id = ContactRequest.Id,
                Name = ContactRequest.Name,
                Email = ContactRequest.Email,
            };

            return Contact;
        }
    }
}
