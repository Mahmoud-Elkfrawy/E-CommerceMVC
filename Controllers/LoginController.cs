using Depitest.Model;
using E_CommerceMVC.Services;
using E_CommerceMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace E_CommerceMVC.Controllers
{
    public class LoginController : Controller
    {
        HttpClient client;

        public LoginController()
        {
           client = new HttpClient();
           client.BaseAddress = new Uri("https://localhost:7145/");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            UserService userService = new UserService(client);
            User user = new User();
            user.UserName = Request.Form["UserName"];
            user.Password = Request.Form["Password"];
            User user1 = userService.GetByName(user.UserName);
            if (user1 == null)
            {
                return RedirectToAction("Index", "Login");

            }

            if (user.UserName == user1.UserName && user.Password == user1.Password)
            {
            return RedirectToAction("Index", "Home");
                
            }
            else
            {
                return View();
            }
        }
    }
}
