using ContactManagement.Domain.Users;

namespace ContactManagement.Domain.Contacts
{
    public class Contact
    {
        public ContactId Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public string Address { get; }
        public string Company { get; }
        public string Note { get; }
        public UserId UserId { get; set; } 
        public User User { get; set; }

    }
}
