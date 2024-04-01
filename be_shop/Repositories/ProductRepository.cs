using AutoMapper;
using be_shop.Entites;
using be_shop.IRepositories;
using be_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace be_shop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Product> Product(long id)
        {
            Product? product = await Task.Run(async () =>
            {
                Product product = await _context.Product.Where(p => p.id == id && !p.is_delete).FirstOrDefaultAsync();
                if (product != null)
                {
                    product.files = await _context.Product_File.Where(p => p.product_id == product.id).ToListAsync();
                }
                return product;
            });
            return product;
        }

        public async Task<Product> ProductCreate(Product product)
        {
            return await Task.Run(() =>
            {
                _context.Product.Add(product);
                _context.SaveChanges();
                foreach (var item in product.files)
                {
                    item.product_id = product.id;
                }
                _context.Product_File.AddRange(product.files);
                _context.SaveChanges();

                return product;
            });
        }

        public async Task<bool> ProductDelete(long id)
        {
            return await Task.Run(async () =>
            {
                Product product = await _context.Product.FirstOrDefaultAsync(p => p.id == id);
                product.is_delete = true;
                _context.Product.Update(product);
                await _context.SaveChangesAsync();

                return true;
            });
        }

        public async Task<PaginationSet<Product>> ProductList(string? keyword, long category_id, int page_number, int page_size)
        {
            return await Task.Run(async () =>
            {
                PaginationSet<Product> response = new PaginationSet<Product>();

                var list_item = _context.Product.Where(p => !p.is_delete);
                if (keyword != null || keyword != "")
                {
                    list_item = list_item.Where(p => p.name.Contains(keyword) || p.name.ToLower().Contains(keyword.ToLower()));
                }
                if (category_id > 0)
                {
                    list_item = list_item.Where(p => p.category_id == category_id);
                }
                List<Product> products = new List<Product>();
                if (page_number > 0)
                {
                    response.totalcount = list_item.Select(p => p.id).Count();
                    response.page = page_number;
                    response.maxpage = (int)Math.Ceiling((decimal)response.totalcount / (page_size));
                    products = await list_item.OrderByDescending(p => p.id).Skip(page_size * (page_number - 1)).Take(page_size).ToListAsync();
                }
                else
                {
                    products = await list_item.OrderByDescending(p => p.id).ToListAsync();
                }
                List<long> ids = products.Select(p => p.id).ToList();
                List<Product_File> product_file = _context.Product_File.Where(p => ids.Contains(p.product_id) && !p.is_delete).ToList();
                foreach (var item in products)
                {
                    item.files = product_file.Where(p => p.product_id == item.id).ToList();
                }
                response.lists = products;

                return response;
            });
        }

        public async Task<Product> ProductModify(Product product)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Entry(product).State = EntityState.Modified;
                    foreach (var item in product.files)
                    {
                        if (item.id == 0)
                        {
                            item.product_id = product.id;
                            _context.Product_File.Add(item);
                        }
                        else
                        {
                            _context.Entry(item).State = EntityState.Modified;
                        }
                    }
                    _context.SaveChanges();
                }
                catch
                {
                    product.id = 0;
                }
                return product;
            });
        }
    }
}
