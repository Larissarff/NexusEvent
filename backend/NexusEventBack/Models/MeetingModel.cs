namespace NexusEventBack.Model;

public class MeetingModel : RegisterModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public DateTime Date { get; set; }
    public string Location { get; set; } = null!;
    public ICollection<MeetingParticipant> Participants { get; set; }
    public Minutes? Minutes { get; set; }
}
