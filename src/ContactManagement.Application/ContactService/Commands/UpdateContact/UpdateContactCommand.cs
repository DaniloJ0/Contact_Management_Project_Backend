using ContactManagement.Domain.Contacts;
using ContactManagement.Domain.Users;
using MediatR;

namespace ContactManagement.Application.ContactService.Commands.Update
{
    public class UpdateContactCommand : IRequest<bool>
    {
        public ContactId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string Note { get; set; }
        public UserId UserId { get; set; }


    }
}
