using be_shop.Entites;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace be_shop.Models.Product
{
    public class ProductViewModel
    {
        public long id { set; get; }
        public long userAdded { set; get; }
        public long? userUpdated { set; get; }
        public DateTime dateAdded { get; set; }
        public long category_id { get; set; } //sản phẩm thuộc danh mục sản phẩm nào
        public string name { get; set; } = string.Empty; //tên sản phẩm
        public double price { get; set; } //giá sản phẩm
        public int views_count { get; set; } //số lượt xem sản phẩm
        public int stock_quantity { get; set; } //sản phẩm còn trong kho
        public int sold_quantity { get; set; } //số sản phẩm đã được bán
        public string avatar { get; set; } //ảnh đại diện cho sản phẩm
        public List<Product_File> files { get; set; }
    }

    public class ProductModel
    {
        public long id { set; get; }
        public long userAdded { set; get; }
        public long? userUpdated { set; get; }
        public DateTime dateAdded { get; set; }
        public DateTime? dateUpdated { get; set; }
        public bool is_delete { get; set; } = false;
        public long category_id { get; set; } //sản phẩm thuộc danh mục sản phẩm nào
        [StringLength(1000)]
        public string name { get; set; } = string.Empty; //tên sản phẩm
        public double price { get; set; } //giá sản phẩm
        public int views_count { get; set; } //số lượt xem sản phẩm
        public int stock_quantity { get; set; } //sản phẩm còn trong kho
        public int sold_quantity { get; set; } //số sản phẩm đã được bán
        public string avatar { get; set; } //ảnh đại diện cho sản phẩm
        public List<Product_File> files { get; set; }
    }

    public class ProductSearchModel
    {
        public string? keyword { set; get; }
        public DateTime? start_date { set; get; }
        public DateTime? end_date { set; get; }
        public int page_size { set; get; }
        public int page_number { set; get; }
    }
}
