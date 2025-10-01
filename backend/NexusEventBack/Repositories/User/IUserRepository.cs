using NexusEventBack.Models;
using NexusEventBack.Services;

namespace NexusEventBack.Repositories;

public interface IUserRepository
{
    Task<UserModel?> GetByIdAsync(int id);
    Task<IEnumerable<UserModel>> GetAllAsync();
    Task<UserModel> AddAsync(UserModel user);
    Task<UserModel?> UpdateAsync(UserModel user);
    Task<bool> DeleteAsync(int id);
    Task<bool> RestoreAsync(int id);
}