using ContactManagement.Domain.Contacts;

namespace ContactManagement.Domain.Users
{
    public class User
    {

        public User(UserId id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public UserId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Contact?> Contacts { get; set; }



    }
}
