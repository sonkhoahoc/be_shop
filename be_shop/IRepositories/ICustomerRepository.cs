using be_shop.Entites;
using be_shop.Models;
using be_shop.Models.Customer;


namespace be_shop.IRepositories
{
    public interface ICustomerRepository
    {
        Task<PaginationSet<CustomerModel>> CustomerList(string? full_name, string? username, int page_number, int page_size);
        Task<CustomerModel> CustomerById(long id);
        Task<CustomerModel> CustomerCreate(CustomerCreateModel model);
        Task<CustomerModel> CustomerModìy(CustomerModifyModel model);
        Task<bool> ChangePassCustomer(ChangePassModel model);
        Task<Customer> CheckCustomer(string username);
        Task<int> CheckCustomerExists(string username, string phone_number, string email);
        int Authenticate(LoginModel login);
    }
}
