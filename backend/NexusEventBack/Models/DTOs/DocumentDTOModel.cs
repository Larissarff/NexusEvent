using Microsoft.AspNetCore.Http;

namespace NexusEventBack.Models;

public class DocumentDTOModel : RegisterModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public IFormFile Image { get; set; } = null!;
    public DocumentTypeEnum Type { get; set; } = null!;
    public int DepartmentId { get; set; }

    public DepartmentEnum Department { get; set; } = null!;
}