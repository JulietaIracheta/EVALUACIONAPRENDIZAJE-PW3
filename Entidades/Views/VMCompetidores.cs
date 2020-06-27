using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Views
{
    public class VMCompetidores
    {

        [Required(ErrorMessage = "Debe ingresar el nombre del competidor")]
        [StringLength(100, ErrorMessage = "Nombre muy largo")]
        public string Nombre { get; set; }

    }
}
