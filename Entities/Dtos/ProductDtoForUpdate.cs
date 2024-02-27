namespace Entities;

public record ProductDtoForUpdate : ProductDto
{
    public bool Showcase { get; set; }
}