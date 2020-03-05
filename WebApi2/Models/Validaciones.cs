using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class Validaciones
    {
        public int OpcionValidacion { get; set; }
        public string Descripcion { get; set; }
        public string Procedimiento { get; set; }
        public int Orden { get; set; }
        public string CambioEstado{ get; set; }

    }
}