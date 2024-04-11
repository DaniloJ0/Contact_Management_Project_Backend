using MediatR;

namespace ContactManagement.Application.ContactService.Queries.GetContacts
{
    public class GetContactQuery : IRequest<List<ContactQuery>>
    {

    }


}
