namespace NexusEventBack.Enums;

public class UserModel : RegisterModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public RoleEnum Role { get; set; }
    public string? FaceImagePath { get; set; }
    public RegistrationStatusEnum Status { get; set; } = RegistrationStatusEnum.Pending;
}