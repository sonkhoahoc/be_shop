using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("order")]
    public class Order: IAuditableEntity
    {
        public string ntoe { get; set; } //ghi chú cho đơn hàng
        public string code { get; set; } // mã đơn hàng thường là tự động tạo mã
        public string customer_name { get; set; } // tên người nhận hàng
        public string customer_address { get; set; } // địa chỉ người nhận hàng
        public string customer_phone { get; set; } // số điệnt thoại người nhận hàng
        public byte status_id { get; set; } // trạng thái đơn hàng
        public double total_amount { get; set; } // tổng tiền cần thành toán bao gồm phí vận chuyển , giá tiền hàng ...
        public string? bank_account { get; set; } // thanh toán qua thể ngân hàng nếu chọn
        public string? transaction_code { get; set; } //Trường này lưu trữ mã giao dịch hoặc mã xác nhận của giao dịch thanh toán. Thường được sử dụng khi khách hàng thanh toán qua các cổng thanh toán trực tuyến, ví điện tử hoặc thẻ tín dụng.
    }
}
