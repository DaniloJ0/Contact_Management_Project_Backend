using ContactManagement.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            try
            {
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<User> GetByIdAsync(UserId id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<bool> UpdateAsync(User user)
        {
            _context.Users.Update(user);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<bool> DeleteAsync(UserId id)
        {
            var user = await GetByIdAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);

                try
                {
                    await _context.SaveChangesAsync();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

    }
}
