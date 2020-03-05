using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2.Conections;
using WebApi2.Models;
using System.Configuration;


namespace WebApi2.Services
{
    public class menuService
    {
        string connString;
        MenuUsuario mnuUsuario;

        public menuService()
        {
            this.connString = ConfigurationManager.ConnectionStrings["FormularioEntities"].ConnectionString;
        }

        public List<MenuUsuario> GetMenuUsuario(string Usuario, string menu)
        {
            Diccionario dic = new Diccionario();
            dic.Add("Usuario", Usuario);
            dic.Add("menu", menu);
            List<MenuUsuario> MenuItemUsuario = new List<MenuUsuario>();
            using (var connPersonas = new Conexion(connString))
            {
                using (var reader = connPersonas.EjecutarSP("Config_MenuItemOpcionesUsuario", dic))
                {
                    while (reader.Read())
                    {
                        MenuUsuario mnuUsuario = new MenuUsuario();
                        mnuUsuario.Menu = reader.GetString(0);
                        mnuUsuario.Item = reader.GetString(1);
                        mnuUsuario.Orden = reader.GetInt32(2);
                        mnuUsuario.ItemCaption = reader.GetString(3);
                        //mnuUsuario.Icono = reader.GetInt32(4);
                        MenuItemUsuario.Add(mnuUsuario);
                    }
                }
            }
            return MenuItemUsuario;
        }
    }
}