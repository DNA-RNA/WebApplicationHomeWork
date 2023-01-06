using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppHomeWork.Areas.Identity.Data;
using WebAppHomeWork.Models;

namespace WebAppHomeWork.Controllers
{
    [Authorize(Policy = "RequireAdmin")]
    public class UserController : Controller
    {
        ApplicationDbContext _dataContext;
        SignInManager<ApplicationUser> _signInManager;

        public UserController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager)
        {
            _dataContext = context;
            _signInManager = signInManager;
        }
       
        public IActionResult Index()
        {
            var users = _dataContext.Users.ToList();
            return View(users);
        }
        public async Task<IActionResult> Edit(string id)
        {
            var users = _dataContext.Users.ToList();
            var user = users.FirstOrDefault(x => x.Id == id);   
            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);
            var roles = _dataContext.Roles.ToList();
           
            var roleItems = roles.Select(role =>
            new SelectListItem(
                role.Name,
                role.Id,
                userRoles.Any(ur => ur.Contains(role.Name)))).ToList();
            var vm = new EditUserViewModel
            {
                User = user,
                Roles = roleItems
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> OnPostAsync(EditUserViewModel data)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Id == data.User.Id);
            if (user == null)
            {
                return NotFound();
            }
         
            var userRolesInDb = await _signInManager.UserManager.GetRolesAsync(user);
            var rolesToAdd = new List<string>();
            var rolesToDelete = new List<string>();

            foreach (var role in data.Roles)
            {
                var assignedInDb = userRolesInDb.FirstOrDefault(ur => ur == role.Text);
                if (role.Selected)
                {
                    if (assignedInDb == null)
                    {
                        rolesToAdd.Add(role.Text);
                    }
                }
                else
                {
                    if (assignedInDb != null)
                    {
                        rolesToDelete.Add(role.Text);
                    }
                }
            }

            if (rolesToAdd.Any())
            {
                await _signInManager.UserManager.AddToRolesAsync(user, rolesToAdd);
            }

            if (rolesToDelete.Any())
            {
                await _signInManager.UserManager.RemoveFromRolesAsync(user, rolesToDelete);
            }
            user.FirstName = data.User.FirstName;
            user.LastName = data.User.LastName;
            user.Email = data.User.Email;

            _dataContext.Update(user);
            _dataContext.SaveChanges();

            return RedirectToAction("Edit", new { id = user.Id });
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }

           
            var userRoles = await _signInManager.UserManager.GetRolesAsync(user);
            if (userRoles.Any())
            {
                await _signInManager.UserManager.RemoveFromRolesAsync(user, userRoles);
            }

            
            _dataContext.Users.Remove(user);
            _dataContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }

   
}
