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
    public class MenuController : ApiController
    {
        public IHttpActionResult GetAllMenuUsuario(string id)
        {
            String Usuario = "34870";
            menuService s = new menuService();
            List<MenuUsuario> lista = s.GetMenuUsuario(Usuario, id);

            try
            {
                return Ok(lista);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Ok(lista);
            }
        }
    }
}
