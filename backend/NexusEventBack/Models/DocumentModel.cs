namespace NexusEventBack.Model;

using NexusEventBack.Enums;

public class DocumentModel : RegisterModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string FilePath { get; set; } = null!;
    public DocumentTypeEnum Type { get; set; } = null!;
    public DateTime UploadDate { get; set; }
    public int DepartmentId { get; set; }

    public Department Department { get; set; } = null!;
}
