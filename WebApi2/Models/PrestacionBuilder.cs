using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class PrestacionBuilder
    {
        protected Prestacion p = new Prestacion();

        public  ICollection<int> AyudasEconomicas { get; set; }

        public  ICollection<Etapas> Etapa { get; set; }

        public  ICollection<Circuito> Circuito { get; set; }

        public  ICollection<Tipologias> Tipologias { get; set; }



    public ICollection<Actores> Actores() {

            List<Actores> Actores = new List<Actores>();
            Actores a = new Actores();
            Actores.Add(a);
            return Actores;
        }

       //public ICollection<int> AyudasEconomicas()
       //{
       //     List<Actores> Actores = new List<Actores>();
       //     Actores a = new Actores();
       //     Actores.Add(a);
       //     return Actores;
       //}

       //public ICollection<Etapas> Etapa()
       // {
       //     List<Actores> Actores = new List<Actores>();
       //     Actores a = new Actores();
       //     Actores.Add(a);
       //     return Etapa;
       // }

       // public ICollection<Etapas> Circuito()
       // {
       //     List<Actores> Actores = new List<Actores>();
       //     Actores a = new Actores();
       //     Actores.Add(a);
       //     return Circuito;
       // }

       // public ICollection<Etapas> Tipologias()
       // {
       //     List<Actores> Actores = new List<Actores>();
       //     Actores a = new Actores();
       //     Actores.Add(a);
       //     return Tipologias;
       // }


    }
}