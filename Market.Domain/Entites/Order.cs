namespace Market.Domain.Entites;

public class Order : BaseEntity
{
    public decimal TotalAmount { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
