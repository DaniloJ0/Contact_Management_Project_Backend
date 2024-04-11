using ContactManagement.Domain.Users;

namespace ContactManagement.Domain.Contacts
{
    public class Contact
    {
        public Contact(ContactId id, string name, string email, string phoneNumber, string address, string company, string note, UserId userId)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Company = company;
            Note = note;
            UserId = userId;
        }

        public ContactId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set;}
        public string Address { get; set;}
        public string Company { get; set;}
        public string Note { get; }
        public UserId UserId { get; set; } 
        public User User { get; set; }

    }
}
