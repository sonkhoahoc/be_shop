using Microsoft.EntityFrameworkCore;

namespace be_shop.Entites
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public virtual DbSet<Admin_User> Admin_User{  get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category_News> Category_News { get; set; }
        public virtual DbSet<Category_Product> Category_Product { get; set; }
        public virtual DbSet<Image_Assets> Image_Assets { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_detail> Order_Detail { get; set; }
        public virtual DbSet<Product> Product { get;}
        public virtual DbSet<Product_File> Product_File { get; set; }
        public virtual DbSet<Product_Size> Product_Size { get; set; }
        public virtual DbSet<Size> size { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
    }
}
