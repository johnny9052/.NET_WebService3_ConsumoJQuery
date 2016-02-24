using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        /*--Ambos proyectos inician vacios
          --Recordar habilitar la linea del web service para los scripts
          -- En el web config añadir todo el bloque de <system.web> --> <webServices>
          -- En el web config añadir todo el bloque de <system.webServer> --> <httpProtocol>
          -- A disfrutar el web service!!
         */


        [WebMethod]
        public string HelloWorld(string nombre)
        {
            return "Hola "+nombre+", ¿que mas?";
        }
    }
}
