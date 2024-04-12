using AutoMapper;
using be_shop.Entites;
using be_shop.Extensions;
using be_shop.IRepositories;
using be_shop.Models;
using be_shop.Models.Customer;

namespace be_shop.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Authenticate(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangePassCustomer(ChangePassModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> CheckCustomer(string username)
        {
            throw new NotImplementedException();
        }

        public Task<int> CheckCustomerExists(string username, string phone_number, string email)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> CustomerById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> CustomerCreate(CustomerCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationSet<CustomerModel>> CustomerList(string? full_name, string? username, int page_number, int page_size)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel> CustomerModìy(CustomerModifyModel model)
        {
            throw new NotImplementedException();
        }
    }
}
