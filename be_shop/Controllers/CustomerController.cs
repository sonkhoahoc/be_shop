using be_shop.IRepositories;
using be_shop.Models;
using be_shop.Models.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace be_shop.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(IConfiguration configuration, IHttpContextAccessor contextAccessor, ICustomerRepository customerRepository)
        {
            _configuration = configuration;
            _contextAccessor = contextAccessor;
            _customerRepository = customerRepository;
        }

        #region
        
        #endregion
    }
}
