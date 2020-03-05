using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using WebApi2.Models;
using WebApi2.Conections;


namespace WebApi2.Services
{
    public class CircuitosService
    {
        string connString;
        Etapas etapa;
        
        public CircuitosService()
        {
            this.connString = ConfigurationManager.ConnectionStrings["FormularioEntities"].ConnectionString;
        }

        public List<Etapas> GetEtapas(int GrupoPrograma)
        {
            Diccionario dic = new Diccionario();
            dic.Add("Grupo", GrupoPrograma);

            List<Etapas> etapas = new List<Etapas>();
            using (var conn = new Conexion(connString))
            {
                using (var reader = conn.EjecutarSP("QryEstados2", dic))
                {
                    while (reader.Read())
                    {
                        Etapas etapa = new Etapas();

                        etapa.id = reader.GetString(0);
                        etapa.label = reader.GetString(1);
                        etapa.group = reader.GetInt32(2);
                        etapas.Add(etapa);
                    }
                }
            }
            return etapas;
        }

        public List<Tarea> GetTareas(int GrupoPrograma)
        {
            Diccionario dic = new Diccionario();
            dic.Add("Grupo", GrupoPrograma);

            List<Tarea> tareas = new List<Tarea>();
            using (var conn = new Conexion(connString))
            {
                using (var reader = conn.EjecutarSP("QryEstados3", dic))
                {
                    while (reader.Read())
                    {
                        Tarea tarea = new Tarea();
                        tarea.id = reader.GetString(0);
                        tarea.from = reader.GetString(1);
                        tarea.to = reader.GetString(2);
                        tarea.arrows = reader.GetString(3);
                        tarea.label = reader.GetString(4);
                        tareas.Add(tarea);
                    }
                }
            }
            return tareas;
        }


        public object GetCircuitosDatos(int GrupoPrograma, int Programa, object JSonSalida)
        {
           
            Diccionario dic = new Diccionario();
            dic.Add("GrupoPrograma", GrupoPrograma);
            dic.Add("Programa", Programa);
            dic.Add("JSonSalida", JSonSalida);

            using (var conn = new Conexion(connString))
            {
                var reader = conn.EjecutarSP("zProgramasWorkFlow_Programa", dic);
                //JSonSalida = dic

            }
                    
            
            return dic["JSONSALIDA"];
        }



    }
}