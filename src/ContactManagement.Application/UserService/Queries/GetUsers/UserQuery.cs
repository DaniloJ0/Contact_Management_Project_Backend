using ContactManagement.Domain.Users;

namespace ContactManagement.Application.UserService.Queries.GetUsers
{
    public class UserQuery
    {
        public UserId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
