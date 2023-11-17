using Microsoft.AspNetCore.Mvc;

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
    }
}

