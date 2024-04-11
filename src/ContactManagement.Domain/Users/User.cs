using ContactManagement.Domain.Contacts;

namespace ContactManagement.Domain.Users
{
    public class User
    {
        public UserId Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }
        public List<Contact> Contacts { get; set; }

    }
}
