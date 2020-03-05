using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class MenuUsuario
    {
        public string  Menu { get; set; }
        public string Item { get; set; }

        public int Orden { get; set; }

        public string ItemCaption { get; set; }

        public string Icono { get; set; }

        

    }
}