using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sample.RP.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public string GetUserId()
        {
            var identity = User.Identity as ClaimsIdentity;
            return identity.FindFirst("sub").Value;
        }
    }
}