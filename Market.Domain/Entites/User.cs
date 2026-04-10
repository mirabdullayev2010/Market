using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Domain.Entites;

[Table("Users")]
public class User : BaseEntity
{
    [Column("FullName")]
    public string FullName { get; set; } = null!;

    [Column("Phone")]
    public string Phone { get; set; } = null!;

    [Column("PasswordHash")]
    public string PasswordHash { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
