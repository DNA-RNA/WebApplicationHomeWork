using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationHomeWork.Controllers
{
    public class OgrenciController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
