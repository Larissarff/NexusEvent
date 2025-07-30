public class UserModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public string? Role { get; set; }  // Admin, Organizer, Participant
    public string? FaceImagePath { get; set; }  // Foto para reconhecimento facial
    public RegistrationStatusEnum Status { get; set; } = RegistrationStatusEnum.Pending;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ICollection<ReservationModel>? Reservations { get; set; } // Reservas de reunião
}