using BooksWeb02.ViewModels;
using ConceptArchitect.BookManagement;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BooksWeb02.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }



        public ActionResult Index(User user)
        {

            return View(user);
        }



        [HttpGet]
        public ViewResult Register()
        {
            return View(new User());
        }



        [HttpPost]
        public async Task<ActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                await userService.AddUser(user);

                return RedirectToAction("Index", user);
            }
            else
            {
                return View(user);
            }



        }



        [HttpGet]
        public ViewResult Login()
        {
            return View(new LoginUserViewModel());



        }



        [HttpPost]
        public async Task<ActionResult> Login(LoginUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                User new_user = await userService.GetUserById(user.Email);
                User _user = new_user;
                if (user.Password == new_user.Password)
                {
                    return RedirectToAction("Index", new_user);
                }
                else
                {
                    return View(user);
                }
            }
            else
            {
                return View(user);
            }

        }



        public async Task<ActionResult> Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
