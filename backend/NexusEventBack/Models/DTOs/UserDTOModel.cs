using Microsoft.AspNetCore.Http;
using NexusEventBack.Enums;

namespace NexusEventBack.Models;

public class UserDTOModel : RegisterModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public RoleEnum Role { get; set; }
    public IFormFile Image { get; set; }
    
    public RegistrationStatusEnum Status { get; set; } = RegistrationStatusEnum.Pending;
}