using Microsoft.AspNetCore.Http;
using NexusEventBack.Enums;

namespace NexusEventBack.Models;

public class UserDTOModel : RegisterModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public RoleEnum Role { get; set; }
    public IFormFile? Image { get; set; }

    public RegistrationStatusEnum Status { get; set; } = RegistrationStatusEnum.Pending;
}