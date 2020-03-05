using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApi2.Models
{
    public class Prestacion
    {
        public int ProgramaID { get; set; }

        public string TipoPrograma { get; set; }

        public string Sexo { get; set; }

        public int Anio { get; set; }

        public string Descripcion { get; set; }

        public int DuracionMaxima { get; set; }

        public int DuracionMinima { get; set; }

        public int EdadMaxima { get; set; }

        public int EdadMinima { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int Prioridad { get; set; }

        public int ReglaValidacion { get; set; }

        public int? CupoMaximo { get; set; }

        public int? CupoMinimo { get; set; }

        public int TipoModificacionAsignacion { get; set; }

        public int CalificacionTipo { get; set; }

        public int Liquida { get; set; }

        public int GrupoPrograma { get; set; }

        public ICollection<Actores> Actores { get; set; }

        public ICollection<int> AyudasEconomicas { get; set; }

        public ICollection<Etapas> Etapa { get; set; }

        public ICollection<Circuito> Circuito { get; set; }

        public ICollection<Tipologias> Tipologias { get; set; }



    }
}