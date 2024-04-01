using be_shop.Entites;
using be_shop.Models;
using be_shop.Models.User;

namespace be_shop.IRepositories
{
    public interface IUserRepository
    {
        Task<PaginationSet<UserModel>> UserList(string? full_name, string? username, int page_number, int page_size);
        Task<UserModel> GetUserById(long id);
        Task<UserModel> UserCreate(UserCreateModel user_add);
        Task<bool> ChangePassUser(ChangePassModel model);
        Task<Admin_User> CheckUser(string username);
        Task<int> CheckUserExists(string username, string phone_number, string email);
        int Authenticate(LoginModel login);
        Task<UserModifyModel> UserModify(UserModifyModel user_update);
    }
}
