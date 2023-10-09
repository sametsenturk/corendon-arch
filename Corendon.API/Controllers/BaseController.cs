using Corendon.Common.Settings.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Corendon.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected int GetCurrentUserId() => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        protected UserTypeEnum GetCurrentUserType() => Enum.Parse<UserTypeEnum>(HttpContext.User.FindFirstValue(ClaimTypes.Role));
    }
}
