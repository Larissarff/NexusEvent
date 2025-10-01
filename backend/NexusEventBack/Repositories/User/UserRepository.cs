using NexusEventBack.Models;
using NexusEventBack.Data;
using Microsoft.EntityFrameworkCore;
using NexusEventBack.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using NexusEventBack.Exceptions;

namespace NexusEventBack.Repositories;

public class UserRepository : IUserRepository
{
    private readonly NexusDbContext _context;

    public UserRepository(NexusDbContext context)
    {
        _context = context;
    }

    public async Task<UserModel?> GetByIdAsync(int id)
        => await _context.Users.FindAsync(id);

    public async Task<IEnumerable<UserModel>> GetAllAsync()
        => await _context.Users.ToListAsync();

    public async Task<UserModel> AddAsync(UserModel user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<UserModel?> UpdateAsync(UserModel user)
    {
        var existing = await _context.Users.FindAsync(user.Id);
        if (existing == null) return null;

        _context.Entry(existing).CurrentValues.SetValues(user);
        await _context.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return false;

        user.IsDeleted = true;
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RestoreAsync(int id)
    {
        var user = await _context.Users.IgnoreQueryFilters()
                                       .FirstOrDefaultAsync(u => u.Id == id);
        if (user == null) return false;

        user.IsDeleted = false;
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return true;
    }

}
