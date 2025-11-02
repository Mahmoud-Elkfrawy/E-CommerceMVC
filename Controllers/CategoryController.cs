using E_CommerceMVC.Services;
using E_CommerceMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceMVC.Controllers
{
    public class CategoryController : Controller
    {

        public IActionResult Index()
        {
            CategoryService categoryService = new CategoryService();
            ProductService productService = new ProductService();

            var model = new ProductViewModel
            {
                Categories = categoryService.Get(),
                Product = null,
            };
            return View(model);
        }
    }
}
