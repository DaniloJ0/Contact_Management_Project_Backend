using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Domain.Contacts;
using ContactManagement.Domain.Users;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;

namespace ContactManagement.Application.ContactService.Commands.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, ContactQuery>
    {
        private readonly IContactRepository _ContactRepository;

        public CreateContactCommandHandler(IContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        public async Task<ContactQuery> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var createdContact = new Contact(
                new ContactId(Guid.NewGuid()),
                request.Name,
                request.Email,
                request.PhoneNumber,
                request.Address,
                request.Company,
                request.Note,
                request.UserId
                );

            await _ContactRepository.AddAsync(createdContact);

            return new ContactQuery
            {
                Id = createdContact.Id,
                Name = createdContact.Name,
                Email = createdContact.Email,
                PhoneNumber = createdContact.PhoneNumber,
                Address = createdContact.Address,
                Company = createdContact.Company,
                Note = createdContact.Note,
                UserId = createdContact.UserId

            };
        }
    }
}
