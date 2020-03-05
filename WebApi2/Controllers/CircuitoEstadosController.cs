using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data;
using System.Web.Http;
using WebApi2.Models;
using WebApi2.Services;

namespace WebApi2.Controllers
{
    public class CircuitoEstadosController : ApiController
    {
        public IHttpActionResult GetAllEstados(int id)
        {
            CircuitosService s = new CircuitosService();
            List<Etapas> etapas = s.GetEtapas(id);

            try
            {
                return Ok(etapas);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Ok (etapas);
            }
        }
    }
}
