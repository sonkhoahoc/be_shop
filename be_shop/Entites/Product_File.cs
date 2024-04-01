using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("product_file")]
    public class Product_File: IAuditableEntity
    {
        public long product_id { get; set; }
        public string name { get; set; } = String.Empty;
        [StringLength(500)]
        public string note { get; set; } = string.Empty;
    }
}
