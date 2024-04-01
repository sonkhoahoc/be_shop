using be_shop.Entites;
using be_shop.Models;

namespace be_shop.IRepositories
{
    public interface IProductRepository
    {
        Task<PaginationSet<Product>> ProductList(string? keyword, long category_id, int page_number, int page_size);
        Task<Product> Product(long id);
        Task<Product> ProductCreate(Product product);
        Task<Product> ProductModify(Product product);
        Task<bool> ProductDelete(long id);
    }
}
