using Microsoft.AspNetCore.Mvc;

namespace Projetoweb_faculdade.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PartialBannerName = "_BannerPrincipal";
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
