namespace ContactManagement.Domain.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(UserId id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(UserId idUser);

    }
}
