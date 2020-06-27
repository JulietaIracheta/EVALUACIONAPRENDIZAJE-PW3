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
    public class ServicioPremios
    {

        PremiosDao PremioDao;
        EA2IRACHETAJULIETAEntities contexto;
        public ServicioPremios(EA2IRACHETAJULIETAEntities context)
        {
            PremioDao = new PremiosDao(context);
            contexto = context;
        }

        public List<Premios> ObtenerListaDePremios()
        {
            List<Premios> listaDePremios = PremioDao.ObtenerListaDePremios();
            return listaDePremios;
        }

        public Premios GuardarPremios(VMPremios vMPremios)
        {
            Premios p = new Premios();
            p = PremioDao.ObtenerPremioPorId(vMPremios.IdCompetidor, vMPremios.Anio);

            if (p != null && p.Anio == vMPremios.Anio) //Existe el competidor en la BD.
            {
                return PremioDao.ActualizarPremio(vMPremios);
            }
            else //No existe el Competidor en la BD.
            {
                Premios pre = new Premios()
                {
                    Anio = vMPremios.Anio,
                    CantidadPremios = vMPremios.CantidadPremios,
                    IdCompetidor = vMPremios.IdCompetidor
                };
                return PremioDao.GuardarPremio(pre);
            }
        }

    }
}
