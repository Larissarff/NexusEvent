using NexusEventBack.Models;

namespace NexusEventBack.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> CreateUserAsync(UserModel user);
        Task<User> UpdateUserAsync(int id, UserModel userModel);
        Task<bool> DeleteUserAsync(int id);
    }
}