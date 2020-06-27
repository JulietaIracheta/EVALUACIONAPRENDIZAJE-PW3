using Entidades;
using Entidades.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class PremiosDao
    {

        EA2IRACHETAJULIETAEntities context;
        public PremiosDao(EA2IRACHETAJULIETAEntities contexto)
        {
            context = contexto;
        }

        public List<Premios> ObtenerListaDePremios()
        {
            List<Premios> ObtengoListaDePremios = context.Premios.ToList();
            return ObtengoListaDePremios;
        }

        public Premios GuardarPremio(Premios p)
        {
            Premios GuardarPremio = context.Premios.Add(p);
            context.SaveChanges();
            return GuardarPremio;
        }

        public Premios ActualizarPremio(VMPremios p)
        {
            Premios premios = ObtenerPremioPorId(p.IdCompetidor, p.Anio);
            premios.CantidadPremios = p.CantidadPremios;
            context.SaveChanges();
            return premios;
        }


        public Premios ObtenerPremioPorId(int idCompetidor, int anio)
        {
            Premios p = context.Premios.Where(o => o.IdCompetidor == idCompetidor).Where(a => a.Anio == anio).FirstOrDefault();
            return p;
        }

    }
}
