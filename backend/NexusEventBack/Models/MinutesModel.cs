namespace NexusEventBack.Models;

public class MinutesModel : RegisterModel
{
    public int Id { get; set; }
    public int MeetingId { get; set; }
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public Meeting? Meeting { get; set; } = null!;
}
