using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.ContactService.Queries.GetContactsByUserId
{
    public class GetContactsByUserIdQuery : IRequest<List<ContactQuery>>
    {
        public UserId Id { get; set; }
    }
}
