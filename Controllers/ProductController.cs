using E_CommerceMVC.Model;
using E_CommerceMVC.Services;
using E_CommerceMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        [Route("/Product/{id}")]
        public IActionResult Index(int id)
        {
            ProductService productService = new ProductService();


            List<Product> product = productService.GetByCategory(id);



            return PartialView("_ProductPartial", product); 
        }
    }
}
