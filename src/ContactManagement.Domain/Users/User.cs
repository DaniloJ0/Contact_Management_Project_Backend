using ContactManagement.Domain.Contacts;

namespace ContactManagement.Domain.Users
{
    public class User
    {

        public User(UserId id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public UserId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Contact?> Contacts { get; set; }



    }
}
