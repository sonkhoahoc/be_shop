using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("category_news")]
    public class Category_News: IAuditableEntity
    {
        public string name { get; set; } = string.Empty;
        public string note { get; set; } = string.Empty;
    }
}
