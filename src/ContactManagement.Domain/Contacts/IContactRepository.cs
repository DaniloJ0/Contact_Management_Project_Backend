using ContactManagement.Domain.Users;

namespace ContactManagement.Domain.Contacts
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAllAsync();
        Task<List<Contact>> GetByUserIdAsync(UserId id);
        Task<Contact> GetByIdAsync(ContactId id);
        Task<bool> AddAsync(Contact contact);
        Task<bool> UpdateAsync(Contact contact);
        Task<bool> DeleteAsync(ContactId id);
    }
}
