using Microsoft.AspNetCore.Mvc;

namespace WebApplicationHomeWork.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
