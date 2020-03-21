using Microsoft.AspNetCore.Antiforgery;
using my52abp.Controllers;

namespace my52abp.Web.Host.Controllers
{
    public class AntiForgeryController : my52abpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
