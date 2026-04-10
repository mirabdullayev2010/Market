using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Domain.Entites;

[Table("Orders")]
public class Order : BaseEntity
{
    [Column("TotalAmount")]
    public decimal TotalAmount { get; set; }

    [Column("UserId")]
    public Guid UserId { get; set; }

    [Column("Users")]
    public User User { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

}
