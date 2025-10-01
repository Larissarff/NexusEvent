using NexusEventBack.Models;

namespace NexusEventBack.Services
{
    public interface IUserService
    {
        Task<UserModel> GetUserByIdAsync(int id);
        Task<IEnumerable<UserModel>> GetAllUsersAsync();
        Task<UserModel> CreateUserAsync(UserModel user);
        Task<UserModel> UpdateUserAsync(int id, UserModel userModel);
        Task<bool> DeleteUserAsync(int id);
        Task<bool> RestoreUserAsync(int id);
    }
}