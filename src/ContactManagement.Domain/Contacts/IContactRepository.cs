using ContactManagement.Domain.Users;

namespace ContactManagement.Domain.Contacts
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAllAsync();
        Task<List<Contact>> GetByUserIdAsync(UserId id);
        Task<Contact> GetByIdAsync(ContactId id);
        Task AddAsync(Contact contact);
        Task UpdateAsync(Contact contact);
        Task DeleteAsync(ContactId id);
    }
}
