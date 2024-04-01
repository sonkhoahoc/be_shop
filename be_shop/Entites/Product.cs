using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("product")]
    public class Product: IAuditableEntity
    {
        public long category_id { get; set; } //sản phẩm thuộc danh mục sản phẩm nào
        [StringLength(1000)]
        public string name { get; set; } = string.Empty; //tên sản phẩm
        public double price { get; set; } //giá sản phẩm
        public int views_count { get; set; } //số lượt xem sản phẩm
        public int stock_quantity { get; set; } //sản phẩm còn trong kho
        public int sold_quantity { get; set; } //số sản phẩm đã được bán
        public string avatar { get; set; } //ảnh đại diện cho sản phẩm
        [NotMapped]
        public List<Product_File> files { get; set; }
    }
}
