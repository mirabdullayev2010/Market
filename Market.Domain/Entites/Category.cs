using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Domain.Entites;

[Table("Categories")]
public class Category : BaseEntity
{
    [Column("name")]
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
