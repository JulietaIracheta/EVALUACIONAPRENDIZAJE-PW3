using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class CompetidoresDao
    {

        EA2IRACHETAJULIETAEntities context;
        public CompetidoresDao(EA2IRACHETAJULIETAEntities contexto)
        {
            context = contexto;
        }

        public List<Competidores> TraerListaDeCompetidores()
        {
            List<Competidores> listaDeCompetidores = context.Competidores.ToList();
            return listaDeCompetidores;
        }

        public Competidores GuardoCompetidor(Competidores Nombre)
        {
            Competidores guardoCompetidor = context.Competidores.Add(Nombre);
            context.SaveChanges();
            return guardoCompetidor;
        }

    }
}
