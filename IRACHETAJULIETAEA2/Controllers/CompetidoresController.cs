using Entidades;
using System.Collections.Generic;
using System.Web.Mvc;
using Servicios;
using Entidades.Views;

namespace IRACHETAJULIETAEA2.Controllers
{
    public class CompetidoresController : Controller
    {
        ServicioCompetidores servicioCompetidores;
        public CompetidoresController()
        {
            EA2IRACHETAJULIETAEntities context = new EA2IRACHETAJULIETAEntities();
            servicioCompetidores = new ServicioCompetidores(context);
        }

        //Muestro lista de competidores existentes
        [HttpGet]
        public ActionResult ListaCompetidores()
        {
            List<Competidores> listaDeCompetidores = servicioCompetidores.TraerListaDeCompetidores();
            return View(listaDeCompetidores);
        }

        //Pantalla alta de competidor
        [HttpGet]
        public ActionResult AltaCompetidor()
        {
            VMCompetidores vmCompetidores = new VMCompetidores();
            return View(vmCompetidores);
        }

        //Obtengo el competidor y lo guardo en la bd
        [HttpPost]
        public ActionResult AltaCompetidor(VMCompetidores vmCompetidor)
        {
            if (!ModelState.IsValid)
            {
                return View(vmCompetidor);
            }
            else
            {
                Competidores competidor = servicioCompetidores.GuardarCompetidor(vmCompetidor);
                TempData["Mensaje"] = "Se ha dado de alta";
            }
            return RedirectToAction("ListaCompetidores");
        }



    }
}