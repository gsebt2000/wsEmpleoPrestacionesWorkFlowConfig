using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2.Models;
using WebApi2.Services;

namespace WebApi2.Controllers
{
    
    public class CircuitosController : ApiController
    {
        
        public List<Etapas> GetAllEstados(int id)
        {
            CircuitosService s = new CircuitosService();
            List<Etapas> etapas = s.GetEtapas(id);

            try
            {
                return etapas;

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return etapas;
            }
        }

        public List<Tarea> GetAllTareas(int id)
        {
            CircuitosService s = new CircuitosService();
            List<Tarea> tareas = s.GetTareas(id);

            try
            {
                return tareas;

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return tareas;
            }
        }

    }
}
