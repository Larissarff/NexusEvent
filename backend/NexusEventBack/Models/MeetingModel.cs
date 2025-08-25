using NexusEventBack.Enums;

namespace NexusEventBack.Models;

public class MeetingModel : RegisterModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime Date { get; set; }
    public string? Location { get; set; } = null!;


    public ICollection<MeetingParticipantModel?> Participants { get; set; } = null!;
    public MinutesModel? Minutes { get; set; }

}
