using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("customer")]
    public class Customer: IAuditableEntity
    {
        [StringLength(20)]
        public string code { set; get; } //mã của tài khoản
        [StringLength(50)]
        public string username { get; set; } = string.Empty; //tên đăng nhập tài khoản
        [StringLength(50)]
        public string password { get; set; } = string.Empty; //mật khẩu tài khoản
        [StringLength(50)]
        public string pass_code { set; get; } = string.Empty; //mã riêng cho tài khoản
        [StringLength(50)]
        public string email { get; set; } = string.Empty; //địa chỉ email người dùng
        [StringLength(12)]
        public string phone_number { get; set; } = string.Empty; //số điện thoại người dùng
        [StringLength(50)]
        public string full_name { get; set; } = string.Empty; //tên đầy đủ của người dùng
        [StringLength(500)]
        public string address { get; set; } = string.Empty; //thông tin địa chỉ người dùng
        public DateTime birthday { set; get; } //ngày sinh
        public byte sex { set; get; } //giới tính
        public bool is_active { set; get; } = true; //tài khoản có được quyền dùng day không
    }
} 
