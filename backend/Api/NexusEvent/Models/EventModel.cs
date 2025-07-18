
public class EventModel
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateTime EventDate { get; set; }
    public required string Location { get; set; }
    public int? MaxCapacity { get; set; }
    public StatusEventEnum Status { get; set; } = StatusEventEnum.Open;

    public ICollection<ReservationModel>? Reservations { get; set; }
}
