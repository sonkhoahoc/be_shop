using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("image_assets")]
    public class Image_Assets: IAuditableEntity
    {
        public string name { get; set; }
        public string description { get; set; } = string.Empty;
        public byte type { get; set; } //0 là logo, 1 là banner, 2 là slider
    }
}
