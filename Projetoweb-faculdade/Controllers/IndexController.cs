using AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Projetoweb_faculdade.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View("About");
        }

        public ActionResult Eventos()
        {
            return View("Events");
        }

        public ActionResult Produtos()
        {
            return View("Products");
        }

        public ActionResult Encomendas()
        {
            return View("SpecialOrders");
        }
    }
}
