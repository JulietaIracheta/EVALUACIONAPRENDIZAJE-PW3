using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Dao;

namespace WebApi.Servicios
{
    public class ServicioPremiosApi
    {
        PremiosDaoApi premiosDaoApi;
        public ServicioPremiosApi(EA2IRACHETAJULIETAEntities context)
        {
            premiosDaoApi = new PremiosDaoApi(context);
        }

        /* Obtengo una lista si es que existe del año que pase por parametros.
         * Luego realizo el foreach recorriendo esta lista y acumulando la cantidad de premios.
         * Retorno la lista */
        public string SumarPremios(int anio) 
        {
            int acumulador = 0;
            List<Premios> listaDeAnios = ObtenerListaDeAnios(anio);

            foreach (var item in listaDeAnios)
            {
              acumulador += item.CantidadPremios;
            }
            return "La cantidad calculada es: " + acumulador;
        }

        /*
         * Obtengo la lista de anios que paso por parametro. (Si es que existe)
         */
        private List<Premios> ObtenerListaDeAnios(int anio)
        {
            List<Premios> listaPremios = premiosDaoApi.TraerAños(anio);
            return listaPremios;
        }
    }
}