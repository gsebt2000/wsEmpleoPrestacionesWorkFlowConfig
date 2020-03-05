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
    public class CircuitoTareasController : ApiController
    {
        object datos;
        public IHttpActionResult GetAllTareas(int id)
        {
            CircuitosService s = new CircuitosService();
            //List<Tarea> tareas = s.GetTareas(id);


            datos = s.GetCircuitosDatos(117, 400, datos);


            try
            {
                return Ok(datos);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Ok(datos);
            }
        }
    }
}
