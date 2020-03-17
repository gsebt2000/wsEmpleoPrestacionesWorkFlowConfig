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
        public IHttpActionResult GetAllTareas(int? id, int? programa, string actor,int? usuarioID , string usuario, int? formato)
        {
            CircuitosService s = new CircuitosService();
            //List<Tarea> tareas = s.GetTareas(id);
            int idGrupo;
            int programaconsulta;
            int usuarioIDConsulta;

            int formatoConsulta;


            //si es null le agrego cero
            idGrupo = id ?? 0;
            programaconsulta = programa ?? 0;
            usuarioIDConsulta = usuarioID ?? 0;
            formatoConsulta = formato ?? 0;





            datos = s.GetCircuitosDatos(idGrupo, programaconsulta, actor, usuarioIDConsulta, usuario, formatoConsulta, datos);


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

        // POST: api/TodoItems

        [Route("api/CircuitoTareas/PostAllTareas")]
        [HttpPost]
        public  IHttpActionResult   PostAllTareas(System.Net.Http.Formatting.FormDataCollection formulario )
           
        {
            //is this condition true ? yes : no



            //chequea el null y el vacio

            var valorgrupoPrograma = formulario.Get("grupoPrograma") ?? "0";
            //var GrupoPrograma = Int32.Parse(formulario.Get("grupoPrograma")=="" ? "0": formulario.Get("grupoPrograma"));
            var GrupoPrograma = Int32.Parse(valorgrupoPrograma == "" ? "0" : valorgrupoPrograma);

            var valorprograma = formulario.Get("programa") ?? "0";
            var Programa = Int32.Parse(valorprograma == "" ? "0" : valorprograma);


            var valoractor = formulario.Get("actor") ?? "";
            var Actor = valoractor == "" ? "" : valoractor;

            var valorusuarioID = formulario.Get("usuarioID") ?? "0";
            var UsuarioId = Int32.Parse(valorusuarioID == "" ? "0" : valorusuarioID);

            // var UsuarioId = Int32.Parse(formulario.Get("usuarioID") == "" ? "0" : formulario.Get("usuarioID"));

            var valorusuario = formulario.Get("usuario") ?? "";
            var Usuario = valorusuario == "" ? "" : valorusuario;


            //  var Formato = Int32.Parse(formulario.Get("formato") == "" ? "0" : formulario.Get("formato"));
            var valorformato = formulario.Get("formato") ?? "0";
            var Formato = Int32.Parse(valorformato == "" ? "0" : valorformato);





            CircuitosService s = new CircuitosService();
            //List<Tarea> tareas = s.GetTareas(id);
           // string id = value.id;

          
 
             datos = s.GetCircuitosDatos(GrupoPrograma, Programa, Actor, UsuarioId, Usuario, Formato, datos);
            
            //datos = s.GetCircuitosDatos(0, 0, "", 0, "", 0, datos);

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

        [Route("api/CircuitoTareas/PostAllTareas2")]
        [HttpPost]
        public IHttpActionResult PostAllTareas2(System.Net.Http.Formatting.FormDataCollection formulario)

        {
            //is this condition true ? yes : no



            //chequea el null y el vacio

            var valorgrupoPrograma = formulario.Get("grupoPrograma") ?? "0";
            //var GrupoPrograma = Int32.Parse(formulario.Get("grupoPrograma")=="" ? "0": formulario.Get("grupoPrograma"));
            var GrupoPrograma = Int32.Parse(valorgrupoPrograma == "" ? "0" : valorgrupoPrograma);

            var valorprograma = formulario.Get("programa") ?? "0";
            var Programa = Int32.Parse(valorprograma == "" ? "0" : valorprograma);


            var valoractor = formulario.Get("actor") ?? "";
            var Actor = valoractor == "" ? "" : valoractor;

            var valorusuarioID = formulario.Get("usuarioID") ?? "0";
            var UsuarioId = Int32.Parse(valorusuarioID == "" ? "0" : valorusuarioID);

            // var UsuarioId = Int32.Parse(formulario.Get("usuarioID") == "" ? "0" : formulario.Get("usuarioID"));

            var valorusuario = formulario.Get("usuario") ?? "";
            var Usuario = valorusuario == "" ? "" : valorusuario;


            //  var Formato = Int32.Parse(formulario.Get("formato") == "" ? "0" : formulario.Get("formato"));
            var valorformato = formulario.Get("formato") ?? "0";
            var Formato = Int32.Parse(valorformato == "" ? "0" : valorformato);





            CircuitosService s = new CircuitosService();
            //List<Tarea> tareas = s.GetTareas(id);
            // string id = value.id;



            datos = s.GetCircuitosDatos(GrupoPrograma, Programa, Actor, UsuarioId, Usuario, Formato, datos);

            //datos = s.GetCircuitosDatos(0, 0, "", 0, "", 0, datos);

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
