using RestauranteRumo.ContextoEF;
using RestauranteRumo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteRumo.Controllers
{
    public class HomeController : Controller
    {
        public readonly ContextoRestaurante contexto;
        public HomeController()
        {
            contexto = new ContextoRestaurante();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListagemBebida()
        {
           var ListaBebida= contexto.BebidaDBSet.ToList(); 

            return View(ListaBebida);
        }

        public ActionResult ListagemPrato()
        {
            var ListaPrato = contexto.PratoDBSet.ToList();


            return View(ListaPrato);
        }

        public ActionResult CadastroPedido()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult CadastroPedido(Pedido pedido)
        {
            contexto.PedidoDBset.Add(pedido);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}