using Dao;
using Entidades;
using Entidades.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioCompetidores
    {

        CompetidoresDao CompetidoresDao;
        public ServicioCompetidores(EA2IRACHETAJULIETAEntities context)
        {
            CompetidoresDao = new CompetidoresDao(context);
        }

        public List<Competidores> TraerListaDeCompetidores()
        {
            List<Competidores> listaCompetidores = CompetidoresDao.TraerListaDeCompetidores();
            return listaCompetidores;
        }

        public Competidores GuardarCompetidor(VMCompetidores vmCompetidor)
        {
            Competidores competidor = new Competidores()
            {
                Nombre = vmCompetidor.Nombre
            };
            return CompetidoresDao.GuardoCompetidor(competidor);
        }

    }
}
