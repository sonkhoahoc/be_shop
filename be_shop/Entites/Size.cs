using System.ComponentModel.DataAnnotations.Schema;

namespace be_shop.Entites
{
    [Table("size")]
    public class Size: IAuditableEntity
    {
        public string name { get; set; } = string.Empty;
    }
}
