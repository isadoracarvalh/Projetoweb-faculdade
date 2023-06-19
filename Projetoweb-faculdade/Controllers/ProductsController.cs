using Microsoft.AspNetCore.Mvc;

namespace Projetoweb_faculdade.Controllers
{
    public class ProductsController : Controller
    {
        
        public ActionResult Index()
        {
            return View("Products");
        }
    }
}
