using System.ComponentModel.DataAnnotations;

namespace be_shop.Entites
{
    public class IAuditableEntity
    {
        [Key]
        public long id { get; set; }
        public long userAdded { get; set; }
        public long? userUpdated { get; set; }
        public DateTime dateAdded { get; set; } = DateTime.Now;
        public DateTime? dateUpdated { get; set; } = DateTime.Now;
        public bool is_delete { get; set; } = false;
    }
}
