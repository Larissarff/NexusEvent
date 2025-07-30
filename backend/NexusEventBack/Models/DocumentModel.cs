using NexusEventBack.Enums;

namespace NexusEventBack.Models;

public class DocumentModel : RegisterModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string FilePath { get; set; } = null!;
    public DocumentTypeEnum Type { get; set; } 
    public DateTime UploadDate { get; set; }
    public int DepartmentId { get; set; }


    public DepartamentEnum Department { get; set; } 
}
