using Microsoft.AspNetCore.Mvc;

namespace E_CommerceMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
