using Microsoft.AspNetCore.Mvc;
using WebApplicationHomeWork.Data;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Controllers
{
    public class LoginController : Controller
    {
        DataContext _dataContext;
        public LoginController(DataContext context)
        {
            _dataContext = context;
        }
      
        [HttpGet]
        public IActionResult GirisYap()
        {

            ViewModel mymodel = new ViewModel();
            mymodel.adminler = _dataContext.admins;
            mymodel.ogrenciler = _dataContext.students;
            return View(mymodel);
        }
      
    }
}
