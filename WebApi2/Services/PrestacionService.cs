using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2.Models;
using System.Configuration;
using System.Data.SqlClient;
using WebApi2.Conections;

namespace WebApi2.Services
{
    public class PrestacionService
    {
        string connString;
        Prestacion modelo;

        public PrestacionService(Prestacion modelo)
        {
            this.connString = ConfigurationManager.ConnectionStrings["FormularioEntities"].ConnectionString;
            this.modelo = modelo;
        }

        public virtual void InicializarModelo(int NroPrestacion)
        {

            Diccionario dic = new Diccionario();
            dic.Add("PrestacionID", NroPrestacion);

            using (var connPersonas = new Conexion(connString))
            {
                using (var reader = connPersonas.EjecutarSP("ServicioGetPrestacionID", dic))
                {
                    while (reader.Read())
                    {
                        modelo.ProgramaID = reader.GetInt32(0);
                        modelo.Descripcion = reader.GetString(1);
                        modelo.TipoPrograma = reader.GetString(2);
                        modelo.Sexo = reader.GetString(3);
                        modelo.Anio = reader.GetInt32(4);
                        modelo.DuracionMaxima = reader.GetInt32(5);
                        modelo.DuracionMinima = reader.GetInt32(6);
                        modelo.EdadMaxima = reader.GetInt32(7);
                        modelo.EdadMinima = reader.GetInt32(8);
                        int FechaInicio = reader.GetOrdinal("FECHA_INICIO");
                        if (!reader.IsDBNull(FechaInicio))
                        {
                            modelo.FechaInicio = Convert.ToDateTime(reader[FechaInicio]);
                        }
                        else
                        {
                            modelo.FechaInicio = null;
                        }

                        int i = reader.GetOrdinal("FECHA_FIN");
                        if (!reader.IsDBNull(i))
                        {
                            modelo.FechaFin = Convert.ToDateTime(reader[i]);
                        }
                        else
                        {
                            modelo.FechaFin = null;
                        }

                        //modelo.FechaFin = ;
                        modelo.Prioridad = reader.GetInt32(11);

                        int CupoMaximo = reader.GetOrdinal("CupoMaximo");
                        if (!reader.IsDBNull(CupoMaximo))
                        {
                            modelo.CupoMaximo = reader.GetInt32(CupoMaximo);
                        }
                        else
                        {
                            modelo.CupoMaximo = null;
                        }

                        int CupoMinimo = reader.GetOrdinal("CupoMinimo");
                        if (!reader.IsDBNull(CupoMinimo))
                        {
                            modelo.CupoMinimo = reader.GetInt32(CupoMinimo);
                        }
                        else
                        {
                            modelo.CupoMinimo = null;
                        }


                        //modelo.CupoMaximo = reader.GetInt32(12);
                        //modelo.CupoMinimo = reader.GetInt32(13);
                        modelo.TipoModificacionAsignacion = reader.GetInt32(14);
                        modelo.CalificacionTipo = reader.GetInt32(15);
                        modelo.Liquida = reader.GetInt32(16);

                        List<Validaciones> Validaciones = new List<Validaciones>();
                        

                        inicializarValidaciones(Validaciones, NroPrestacion);
                        inicializarCircuito(Validaciones, NroPrestacion);
                        

                            


                    }

                }
            }

        }

            public void inicializarCircuito(List<Validaciones> Validaciones, int NroPrestacion)
            {
            //Diccionario dic2 = new Diccionario();

            //dic2.Add("PrestacionID", NroPrestacion);

            //using (var connPersonas = new Conexion(connString))
            //{
            //    List<Circuito> Cir = new List<Circuito>();
            //    using (var reader2 = connPersonas.EjecutarSP("ServicioGetPrestacionIDCircuito", dic2))
            //    {

            //        modelo.Circuito = new List<Circuito>();


            //        while (reader2.Read())
            //        {
            //            Circuito c = new Circuito();
            //            c.Actor = reader2.GetString(0);
            //            c.CambioEstado = reader2.GetString(1);
            //            c.DescripcionCambioEstado = reader2.GetString(2);

            //            c.Etapa = new Etapas();
            //            c.Resultado = new Resultados();
            //            c.Etapa.EtapaID = reader2.GetInt32(3);
            //            c.Etapa.Descripcion = reader2.GetString(4);
            //            c.Resultado.Resultado = reader2.GetInt32(5);
            //            c.Resultado.Descripcion = reader2.GetString(6);
            //            c.Nota = reader2.GetString(7);
            //            c.Validaciones = new List<Validaciones>();
            //            List<Validaciones> Validaciones2 = new List<Validaciones>();
            //            CalculaEstados(Validaciones, c.CambioEstado, Validaciones2);
            //            c.Validaciones = Validaciones2;
            //            Cir.Add(c);
            //            Validaciones2.Clear();
            //            ;
                   // }
                  
//}
                //modelo.Circuito = Cir;
                //AgregaActores(NroPrestacion);
               

                //}

            



        }

        public void CalculaEstados(List<Validaciones> Validaciones, string CambioEstado, List<Validaciones> Validaciones2) {
            foreach (Validaciones v in Validaciones) {
                if (v.CambioEstado == CambioEstado)
                {
                    Validaciones2.Add(v);
                }

            }

        }


        public void inicializarValidaciones(List<Validaciones> Validaciones, int NroPrestacion)
        {
            Diccionario dic3 = new Diccionario();
            dic3.Add("PrestacionID", NroPrestacion);
            dic3.Add("CambioEstado", "0.0_1.1");
            dic3.Add("ValidacionCircuito", 100);

            using (var connPersonas = new Conexion(connString))
            {
                using (var reader3 = connPersonas.EjecutarSP("ServicioGetPrestacionTareaReglas", dic3))
                {
                   

                    while (reader3.Read())
                    {
                        
                        Validaciones v = new Validaciones();
                        v.OpcionValidacion = reader3.GetInt32(0);
                        v.Descripcion = reader3.GetString(1);
                        v.Procedimiento = reader3.GetString(2);
                        v.Orden = reader3.GetInt32(3);
                        v.CambioEstado = reader3.GetString(4);
                        Validaciones.Add(v);
                    }
                }

            }



        }

        public void AgregaActores(int NroPrestacion)
        {
            //Diccionario dic = new Diccionario();
            //dic.Add("PrestacionID", NroPrestacion);

            //using (var connPersonas = new Conexion(connString))
            //{
            //    using (var reader = connPersonas.EjecutarSP("ServicioGetPrestacionActores", dic))
            //    {
            //        modelo.Actores = new List<Actores>();
            //        while (reader.Read())
            //        {
            //            Actores actor = new Actores();
            //            actor.Actor = reader.GetString(0);
            //            actor.Lugar = reader.GetInt32(1);
            //            actor.Descripcion = reader.GetString(2);
            //            modelo.Actores.Add(actor);
            //        }
            //    }

            //}

        }



    }
}
