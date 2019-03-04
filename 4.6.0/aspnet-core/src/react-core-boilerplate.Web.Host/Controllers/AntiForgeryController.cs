using Microsoft.AspNetCore.Antiforgery;
using react-core-boilerplate.Controllers;

namespace react-core-boilerplate.Web.Host.Controllers
{
    public class AntiForgeryController : react-core-boilerplateControllerBase
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
