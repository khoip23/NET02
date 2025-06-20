using System.ComponentModel.DataAnnotations;

public class ProductModelApi
{
    [Required(ErrorMessage = "input id")]
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Price { get; set; }
    public Uri? Img { get; set; }
    public string? Description { get; set; }
    public string? Type { get; set; }
    public bool Deleted { get; set; }
}
