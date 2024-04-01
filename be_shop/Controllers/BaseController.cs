using be_shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace be_shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase

    {
        protected long userid(IHttpContextAccessor _httpContextAccessor)
        {
            long id = long.Parse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type.Equals("sid", StringComparison.OrdinalIgnoreCase))?.Value ?? "0");
            return id;
        }
        protected IActionResult RouteToInternalServerError()
        {
            // Return server error
            return StatusCode(500, new ResponseSingleContentModel<IResponseData>
            {
                StatusCode = 500,
                Message = "Internal Server Error!",
            });
        }

        protected IActionResult RouteToFordbiddenServerError()
        {
            return StatusCode(403, new ResponseSingleContentModel<IResponseData>
            {
                StatusCode = 403,
                Message = "Fordbidden!",

            });
        }


    }
}
