using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Servicios;

namespace WebApi.Controllers
{
    public class CantidadTotalPremiosApiController : ApiController
    {
        ServicioPremiosApi servicioPremiosApi;
        public CantidadTotalPremiosApiController()
        {
            EA2IRACHETAJULIETAEntities ctx = new EA2IRACHETAJULIETAEntities();
            servicioPremiosApi = new ServicioPremiosApi(ctx);
        }

        /*
         * Obtengo el string del servicio SumarPremios.
         */

        public string Get(int anio)
        {
            string resultado = servicioPremiosApi.SumarPremios(anio);
            return resultado;
        }



    }
}
