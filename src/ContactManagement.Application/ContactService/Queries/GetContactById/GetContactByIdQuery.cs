using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Queries.GetContactById
{
    public class GetContactByIdQuery : IRequest<ContactQuery>
    {
        public ContactId Id { get; set; }
    }
}
