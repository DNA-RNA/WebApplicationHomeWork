using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppHomeWork.Controllers
{
    public class RoleController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Policy ="RequireManager")]
        public IActionResult Manager()
        {
            return View();
        }
        [Authorize(Policy = "RequireAdmin")]
        public IActionResult Admin() 
        { 
            return View(); 
        }
    }
}
