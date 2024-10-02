using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDemo.Api.Domain.Entities
{
    [Table("product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; init; }

        [Column("Product_name")]
        [MaxLength(125)]
        public string? ProductName { get; init; }

        [Column("Product_code")]
        [MaxLength(10)]
        public string? ProductCode {  get; init; }

        [Column("price", TypeName= "decimal(7,2)")]
        public decimal Price { get; init; }

    }
}
