using Entidades;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Dao
{
    public class PremiosDaoApi
    {
        EA2IRACHETAJULIETAEntities context;
        public PremiosDaoApi(EA2IRACHETAJULIETAEntities contexto)
        {
            context = contexto;
        }

        /*
         * Obtengo la lista de años siempre y cuando el id pasado sea igual al 
         * que estar cargado en la base.
         */
        public List<Premios> TraerAños(int anio)
        {
            List<Premios> listaAnios = context.Premios.Where(o => o.Anio == anio).ToList();
            return listaAnios;
        }
    }
}