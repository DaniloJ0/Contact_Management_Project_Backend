using ContactManagement.Domain.Contacts;
using MediatR;

namespace ContactManagement.Application.ContactService.Commands.DeleteContact
{
    public class DeleteContactCommand : IRequest<bool>
    {
        public ContactId Id { get; set; }
    }
}
