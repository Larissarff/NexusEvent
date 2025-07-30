using NexusEventBack.Enums;

namespace NexusEventBack.Models;

public class MeetingParticipantModel
{
    public int Id { get; set; }
    public int MeetingId { get; set; }
    public int UserId { get; set; }
    public RegistrationStatusEnum Status { get; set; }

    public MeetingModel? Meeting { get; set; } = null!;
    public UserModel? User { get; set; } = null!;
}
