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

    public class ProductsController : ApiController
    {
        // GET api/<controller>
        //Prestacion[] prestacion = new Prestacion[]
        //{
        //    new Prestacion { ProgramaID = 1, Descripcion= "Programa 86" },            //new Product { Id = 2, Name = "Programa 104", Category = "Toys", Price = 3.75M },
        //    new Prestacion { ProgramaID = 2, Descripcion= "Programa 104"} };
        ////    //new Product { Id = 3, Name = "Programa 98", Category = "Hardware", Price = 16.99M }
        Prestacion p = new Prestacion();
        Etapas e = new Etapas();

        
        public Prestacion GetAllProducts()
        {

            try
            {

                int NroPrestacion = 696;

                Prestacion p = new Prestacion();
                PrestacionService ps = new PrestacionService(p);

                ps.InicializarModelo(NroPrestacion);

                
                //e.EtapaID = "4.1_7.1";
                //e.Descripcion = "Aprobacion de Proyectos";
                //p.ProgramaID = 5;
                //p.Descripcion = "Programa Jovenes";
                //p.Etapa = new List<Etapas>();
                //p.Etapa.Add(e);

                
                 return p;
            }
            catch (Exception e )
            {
                Console.WriteLine("{0} Exception caught.", e);
                return p;

            }
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = p;
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // GET api/<controller>/5
      

        // POST api/<controller>
       
    }
}
