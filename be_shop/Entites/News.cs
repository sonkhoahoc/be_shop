using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("news")]
    public class News: IAuditableEntity
    {
        public long category_id { get; set; }
        [StringLength(500)]
        public string title { get; set; } = string.Empty;
        public string short_description { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;
        public string avatar { get; set; }
        public string? note { get; set; }
    }
}
