using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            _logger.LogInformation("Welcome to product");
            return View();
        }
    }
}
