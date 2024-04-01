using AutoMapper;
using be_shop.Entites;
using be_shop.Extensions;
using be_shop.IRepositories;
using be_shop.Models;
using be_shop.Models.User;

namespace be_shop.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public int Authenticate(LoginModel login)
        {
            Admin_User user = _context.Admin_User.Where(u => !u.is_delete && u.username.ToUpper() == login.username.ToUpper() || u.email.ToUpper() == login.username.ToUpper()).FirstOrDefault();
            if (user == null)
            {
                return -1;
            }
            else
            {
                var passWord = Encryptor.MD5Hash(login.password + user.pass_code);
                return passWord != user.password ? 2 : 1;
            }
        }

        public async Task<bool> ChangePassUser(ChangePassModel model)
        {
            var user = _context.Admin_User.FirstOrDefault(u => u.id == model.id);
            LoginModel login = new LoginModel
            {
                password = model.passwordOld,
                username = user.username,
            };
            if (Authenticate(login) == 1)
            {
                user.dateUpdated = DateTime.UtcNow;
                user.pass_code = Encryptor.RandomPassword();
                user.password = Encryptor.MD5Hash(model.passwordNew + user.pass_code);
                _context.Admin_User.Update(user);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Admin_User> CheckUser(string username)
        {
            return _context.Admin_User.Where(u => u.username.ToUpper() == username.ToUpper() || u.email.ToUpper() == username.ToUpper() || u.phone_number == username).FirstOrDefault();
        }

        public async Task<int> CheckUserExists(string username, string phone_number, string email)
        {
            return _context.Admin_User.Where(r => r.username.ToUpper() == username.ToUpper() || r.email.ToUpper() == email.ToUpper() || r.phone_number == phone_number).Count();
        }

        public async Task<UserModel> GetUserById(long id)
        {
            Admin_User user = _context.Admin_User.Find(id);
            UserModel model = _mapper.Map<UserModel>(user);
            return model;
        }

        public async Task<UserModel> UserCreate(UserCreateModel user_add)
        {
            Admin_User user = _mapper.Map<Admin_User>(user_add);
            user.pass_code = Encryptor.RandomPassword();
            user.password = Encryptor.MD5Hash(user.password + user.pass_code);
            _context.Admin_User.Add(user);
            _context.SaveChanges();
            UserModel model = _mapper.Map<UserModel>(user);
            return model;
        }

        public async Task<PaginationSet<UserModel>> UserList(string? full_name, string? username, int page_number, int page_size)
        {
            PaginationSet<UserModel> response = new PaginationSet<UserModel>();
            IEnumerable<UserModel> list_item = from a in _context.Admin_User
                                               select new UserModel
                                               {
                                                   address = a.address,
                                                   is_active = a.is_active,
                                                   sex = a.sex,
                                                   birthday = a.birthday,
                                                   email = a.email,
                                                   full_name = a.full_name,
                                                   id = a.id,
                                                   phone_number = a.phone_number,
                                                   userAdded = a.userAdded,
                                                   username = a.username,
                                                   userUpdated = a.userUpdated,
                                               };
            if (username != null && username != "")
            {
                list_item = list_item.Where(u => u.username.Contains(username));
            }
            if (full_name != null && full_name != "")
            {
                list_item = list_item.Where(u => u.full_name.Contains(full_name));
            }
            if (page_number > 0)
            {
                response.totalcount = list_item.Select(u => u.id).Count();
                response.page = page_number;
                response.maxpage = (int)Math.Ceiling((decimal)response.totalcount / (page_size));
                response.lists = list_item.OrderByDescending(u => u.id).Skip(page_size * (page_number - 1)).Take(page_size).ToList();
            }
            else
            {
                response.lists = list_item.OrderByDescending(u => u.id).ToList();
            }
            return response;
        }

        public async Task<UserModifyModel> UserModify(UserModifyModel user_update)
        {
            var user = _context.Admin_User.FirstOrDefault(u => u.id == user_update.id);

            user.address = user_update.address;
            user.email = user_update.email;
            user.phone_number = user_update.phone_number;
            user.birthday = user_update.birthday;

            user.sex = user_update.sex;
            user.type = user_update.type;
            user.full_name = user_update.full_name;
            user.is_active = user_update.is_active;
            user.dateUpdated = DateTime.Now;

            UserModifyModel model = _mapper.Map<UserModifyModel>(user);

            _context.Admin_User.Update(user);
            _context.SaveChanges();
            return user_update;
        }
    }
}
