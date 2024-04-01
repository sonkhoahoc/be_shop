using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("cart")]
    public class Cart: IAuditableEntity
    {
        public long cart_id { get; set; }
        public long user_id { get; set; }
        public long product_id { get; set; }
        public long size_id { get; set; }
        public int quantity { get; set; } = 0;
        public double total_price {  get; set; }
    }
}
