using Microsoft.AspNetCore.Mvc;
using Restart.Models;

namespace Restart.Controllers
{
    public class ITProductsController : Controller
    {
        private readonly IITProductsRepository repo;

        public ITProductsController(IITProductsRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetALLITProducts();
            return View(products);

        }

        public IActionResult Product(int id) 
        {
            var product = repo.GetProductByMoves(id);
            return View(product);        
        
        }

        public IActionResult UpdateProduct(int id)
        {
            Product product = repo.GetProductByMoves(id);
            if (product == null)
            {
                return View("ProductNotFound");
            }
            return View(product);
        }

        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.MovesID });
        }
    }
}

