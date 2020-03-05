using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class Tarea
    {
        public string id { get; set; }

        public string from { get; set; }

        public string to { get; set; }

        public string arrows { get; set; }

        public string label { get; set; }

    }
}