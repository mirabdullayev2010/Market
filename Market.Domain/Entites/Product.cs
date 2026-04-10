using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Domain.Entites;

[Table("Products")]
public class Product : BaseEntity
{
    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("Decription")]
    public string? Description { get; set; }

    [Column("Price")]
    public decimal Price { get; set; }

    [Column("StockQuantity")]
    public int StockQuantity { get; set; }

    [Column("CategoryId")]
    public Guid CategoryId { get; set; }

    [Column("Category")]
    public Category Category { get; set; } = null!;
}
