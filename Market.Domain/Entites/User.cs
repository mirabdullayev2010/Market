namespace Market.Domain.Entites;

public class User : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
