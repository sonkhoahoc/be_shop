using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("order_detail")]
    public class Order_detail: IAuditableEntity
    {
        public long order_id { get; set; }
        public long product_id { get; set; }
        public long size_id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
