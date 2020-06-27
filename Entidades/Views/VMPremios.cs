using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Views
{
    public class VMPremios
    {

        [Required(ErrorMessage = "El campo año es obligatorio")]
        [Min(2011, ErrorMessage = "El año ingresado debe ser mayor a 2010")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "El campo Cantidad de premios es obligatorio")]
        [Min(1, ErrorMessage = "Debe ingresar al menos un premio")]
        [Max(50, ErrorMessage = "La cantidad maxima de premios es de 50")]
        public int CantidadPremios { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un competidor")]
        public List<Competidores> Competidores = new List<Competidores>();

        public int IdCompetidor { get; set; }

    }
}
