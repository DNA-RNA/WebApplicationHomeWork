using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppHomeWork.Areas.Identity.Data;

namespace WebAppHomeWork.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _dataContext;
       
        public UserController(ApplicationDbContext context)
        {
            _dataContext = context;
        }
        [Authorize(Policy = "RequireAdmin")]
        public IActionResult Index()
        {
            var users = _dataContext.Users.ToList();
            return View(users);
        }
        public IActionResult Edit(string id)
        {

            var user = _dataContext.Users.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

    }
}
