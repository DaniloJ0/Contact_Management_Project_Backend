using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Queries.GetContacts
{
    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<ContactQuery>>
    {

        private readonly IContactRepository _ContactRepository;

        public GetContactQueryHandler(IContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        public async Task<List<ContactQuery>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var Contacts = await _ContactRepository.GetAllAsync();
            var ContactList = Contacts.Select(x => new ContactQuery
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
            }).ToList();

            return ContactList;
        }
    }
}
