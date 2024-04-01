using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("product_size")]
    public class Product_Size: IAuditableEntity
    {
        public long product_id { get; set; }
        public long size_id { get; set;}
        public int quantity { get; set;}
    }
}
