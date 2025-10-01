namespace NexusEventBack.Models;

public abstract class RegisterModel
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    
    public bool IsDeleted { get; set; } = false;
}