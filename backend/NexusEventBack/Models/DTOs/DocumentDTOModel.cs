using Microsoft.AspNetCore.Http;
using NexusEventBack.Enums;

namespace NexusEventBack.Models;

public class DocumentDTOModel : RegisterModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public IFormFile Image { get; set; } = null!;  
    public DocumentTypeEnum Type { get; set; }


    public DepartamentEnum Department { get; set; } 
}