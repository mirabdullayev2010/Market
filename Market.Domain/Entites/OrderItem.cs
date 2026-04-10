using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Domain.Entites;

[Table("OrderItems")]
public class OrderItem : BaseEntity
{
    [Column("OrderId")]
    public Guid OrderId { get; set; }

    [Column("Order")]
    public Order Order { get; set; } = null!;

    [Column("ProductId")]
    public Guid ProductId { get; set; }

    [Column("Product")]
    public Product Product { get; set; } = null!;

    [Column("Quantity")]
    public int Quantity { get; set; }

    [Column("Price")]
    public decimal Price { get; set; }
}
