using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2.Models;

namespace WebApi2.Models
{
    public class Circuito
    {
        public string Actor { get; set; }
        public string CambioEstado { get; set; }
        public string DescripcionCambioEstado { get; set; }
        public Etapas Etapa { get; set; }
        public Resultados Resultado { get; set; }
        public string Nota { get; set; }
        public ICollection <Validaciones> Validaciones  { get; set; }


    }
}