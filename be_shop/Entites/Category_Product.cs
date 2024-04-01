using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("category_product")]
    public class Category_Product: IAuditableEntity
    {
        [StringLength(20)]
        public string code { get; set; } = string.Empty; //mã định danh cho danh mục sản phẩm
        [StringLength(250)]
        public string name { get; set; } = string.Empty; //tên danh mục
        [StringLength(1500)]
        public string note {  get; set; } = string.Empty; //ghi chú , mô tả danh mục
        public long parent_id { get; set; } //id ủa danh mục cha mà danh mục hiện tại thuộc về. Điều này cho phép bạn tạo một cấu trúc danh mục sản phẩm đa cấp. 
        public int order {  get; set; } //thứ tự sắp xếp của danh mục
        public byte status_id { get; set; } //trạng thái của danh mục
    }
}
