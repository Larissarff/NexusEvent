
public class ReservationModel
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public UserModel? User { get; set; }

    public int EventId { get; set; }
    public EventModel? Event { get; set; }
    public StatusReservationEnum Status { get; set; } = StatusReservationEnum.Pending;

    public DateTime ReservationDate { get; set; }
    public DateTime? CheckInTime { get; set; }  // Preenchido no check-in facial
}
