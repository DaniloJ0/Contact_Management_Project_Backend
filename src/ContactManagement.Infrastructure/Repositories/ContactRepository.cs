using ContactManagement.Domain.Contacts;
using ContactManagement.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Infrastructure.Repositories
{
    public class ContactRepository : IContactRepository 
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }

        public async Task<Contact> GetByIdAsync(ContactId id)
        {
            return await _context.Contacts.FindAsync(id);
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task UpdateAsync(Contact contact)
        {
            _context.Contacts.Update(contact);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ContactId id)
        {
            var contact = await GetByIdAsync(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Contact>?> GetByUserIdAsync(UserId id) => 
            await _context.Contacts.Where(c => c.UserId == id).ToListAsync();

    }
}
