using E_CommerceMVC.Model;
using E_CommerceMVC.Services;
using E_CommerceMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace E_CommerceMVC.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            UserService userService = new UserService();
            User user = new User();
            user.UserName = Request.Form["UserName"];
            user.Password = Request.Form["Password"];

            if (await userService.CheckUserName(user.UserName, user.Password))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
