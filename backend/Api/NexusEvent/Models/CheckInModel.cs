public class CheckInLogModel
{
    public int Id { get; set; }

    public int ReservationId { get; set; }
    public ReservationModel? Reservation { get; set; }

    public DateTime CheckInTime { get; set; } = DateTime.UtcNow;
    public bool Success { get; set; }
    public string? VerificationDetails { get; set; }  
}
