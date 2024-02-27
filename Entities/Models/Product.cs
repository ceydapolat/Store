using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int? CategoryId { get; set; }        //Foreign Key
    public Category? Category { get; set; }     //Navigation property
    public string? Summary { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public bool Showcase { get; set; }
}
