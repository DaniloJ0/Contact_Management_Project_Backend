using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Domain.Contacts;
using ContactManagement.Domain.Users;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;

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
                PhoneNumber = ContactRequest.PhoneNumber,
                Address =ContactRequest.Address,
                Company =ContactRequest.Company,
                Note =ContactRequest.Note,
                UserId =ContactRequest.UserId
        };

            return Contact;
        }
    }
}
