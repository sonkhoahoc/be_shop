using be_shop.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using be_shop.Models;
using be_shop.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace be_shop.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;

        public UserController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _configuration = configuration;
        }

        #region user
        [AllowAnonymous]
        [HttpPost("admin-user-create")]
        public async Task<IActionResult> UserCreate([FromBody] UserCreateModel model)
        {
            try
            {
                int checkUser = await _userRepository.CheckUserExists(model.username, model.email, model.phone_number);
                if (checkUser > 0)
                {
                    return Ok(new ResponseSingleContentModel<string>
                    {
                        StatusCode = 400,
                        Message = "Tài khoản hoặc email hoặc số điện thoại đã tồn tại",
                        Data = string.Empty
                    });
                }

                var response = await _userRepository.UserCreate(model);
                return Ok(new ResponseSingleContentModel<UserModel>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = response
                });
            }
            catch (Exception ex)
            {
                return this.RouteToInternalServerError();
            }
        }

        [HttpPost("admin-user-modify")]
        public async Task<IActionResult> UserModify([FromBody] UserModifyModel user_update)
        {
            try
            {
                var response = await this._userRepository.UserModify(user_update);
                return Ok(new ResponseSingleContentModel<UserModifyModel>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = response
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseSingleContentModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpGet("admin-user-list")]
        public async Task<IActionResult> UserList(string? full_name, string? username, int page_number, int page_size = 20)
        {
            try
            {
                PaginationSet<UserModel> Data = await _userRepository.UserList(full_name, username, page_number, page_size);
                return Ok(new ResponseSingleContentModel<PaginationSet<UserModel>>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = Data
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseSingleContentModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpGet("admin-authorize-check")]
        public async Task<IActionResult> GetUserById()
        {
            try
            {
                long id = userid(_httpContextAccessor);
                var user = await _userRepository.GetUserById(id);

                return Ok(new ResponseSingleContentModel<UserModel>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = user
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseSingleContentModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpGet("admin-user")]
        public async Task<IActionResult> GetUserById(long id)
        {
            try
            {
                var user = await _userRepository.GetUserById(id);

                return Ok(new ResponseSingleContentModel<UserModel>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = user
                });
            }
            catch
            {
                return Ok(new ResponseSingleContentModel<string>
                {
                    StatusCode = 500,
                    Message = "Có lỗi xảy ra trong quá trình xử lý",
                    Data = string.Empty
                });
            }
        }

        [HttpPost("admin-user-changepass")]
        public async Task<IActionResult> ChecChangePassUser(ChangePassModel model)
        {
            try
            {
                var user = await _userRepository.ChangePassUser(model);

                return Ok(new ResponseSingleContentModel<string>
                {
                    StatusCode = 200,
                    Message = "Đổi mật khẩu thành công",
                    Data = null
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseSingleContentModel<string>
                {
                    StatusCode = 500,
                    Message = "Có lỗi xảy ra trong quá trình xử lý",
                    Data = string.Empty
                });
            }
        }

        [AllowAnonymous]
        [HttpPost("admin-user-login")]
        public async Task<IActionResult> Login(LoginModel login)
        {
            try
            {
                var user = await _userRepository.CheckUser(login.username);
                if (user != null)
                {
                    int checlAcc = _userRepository.Authenticate(login);
                    UserTokenModel userAuthen = new();
                    if (checlAcc == 1)
                    {
                        ClaimModel claim = new ClaimModel
                        {
                            email = user.email,
                            full_name = user.full_name,
                            id = user.id,
                            username = user.username,
                        };
                        string tokenString = GenerateToken(claim);
                        userAuthen.token = tokenString;
                        userAuthen.id = user.id;
                        userAuthen.username = user.username;
                        userAuthen.full_name = user.full_name;
                        userAuthen.token = tokenString;
                        return Ok(new ResponseSingleContentModel<UserTokenModel>
                        {
                            StatusCode = 200,
                            Message = "Đăng nhập thành công",
                            Data = userAuthen
                        });
                    }
                    else
                    {
                        return Ok(new ResponseSingleContentModel<string>
                        {
                            StatusCode = 500,
                            Message = "Sai tài khoản hoặc mật khẩu",
                            Data = null
                        });
                    }
                }
                else
                {
                    return Ok(new ResponseSingleContentModel<string>
                    {
                        StatusCode = 500,
                        Message = "Tài khoản không tồn tại trong hệ thống",
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                return Ok(new ResponseSingleContentModel<string>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = string.Empty
                });
            }
        }

        private string GenerateToken(ClaimModel user)
        {
            var identity = GetClaims(user);

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["TokenSettings:Key"]));
            var token = new JwtSecurityToken(
            _configuration["TokenSettings:Issuer"],
             _configuration["TokenSettings:Audience"],
              expires: DateTime.Now.AddHours(9),
              claims: identity,
              signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
              );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private IEnumerable<Claim> GetClaims(ClaimModel user)
        {
            var claims = new List<Claim>
            {
               new Claim(JwtRegisteredClaimNames.Sub, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Typ, user.type.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.username.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.full_name),
                new Claim(JwtRegisteredClaimNames.Email, user.email),
                new Claim(JwtRegisteredClaimNames.Sid, user.id.ToString())
            };

            return claims;
        }
        #endregion
    }
}
