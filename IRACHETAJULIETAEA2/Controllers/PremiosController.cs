using Entidades;
using Entidades.Views;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IRACHETAJULIETAEA2.Controllers
{
    public class PremiosController : Controller
    {
        ServicioPremios servicioPremios;
        ServicioCompetidores servicioCompetidores;

        public PremiosController()
        {
            EA2IRACHETAJULIETAEntities context = new EA2IRACHETAJULIETAEntities();
            servicioPremios = new ServicioPremios(context);
            servicioCompetidores = new ServicioCompetidores(context);
        }

        [HttpGet]
        public ActionResult ListaPremios()
        {
            List<Premios> listaDepremios = servicioPremios.ObtenerListaDePremios();
            return View(listaDepremios);
        }

        [HttpGet]
        public ActionResult AltaPremios() /*Aca realizo este pequeño foreach para traer los datos del select que luego se muestra en la vista.*/
        {
            VMPremios vm = new VMPremios();
            List<Competidores> listaNombreCompetidores = new List<Competidores>();
            listaNombreCompetidores = servicioCompetidores.TraerListaDeCompetidores();

            foreach (var item in listaNombreCompetidores)
            {
                vm.Competidores.Add(item);
            }
            return View(vm);
        }


        [HttpPost]
        public ActionResult AltaPremios(VMPremios vmPremios)
        {
            List<Competidores> listaNombreCompetidores = new List<Competidores>();
            listaNombreCompetidores = servicioCompetidores.TraerListaDeCompetidores();

            foreach (var item in listaNombreCompetidores)
            {
                vmPremios.Competidores.Add(item);
            }

            if (!ModelState.IsValid)
            {
                return View(vmPremios);
            }
            else
            {

                //listaNombreCompetidores = servicioCompetidores.TraerListaDeCompetidores();
                Premios guardarPremio = servicioPremios.GuardarPremios(vmPremios);
                TempData["Mensaje"] = "Alta";
            }
            return RedirectToAction("ListaPremios");
        }
    }
}