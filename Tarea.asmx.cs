using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiciosWeb
{
    /// <summary>
    /// Descripción breve de Tarea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Tarea : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "SERVICIOS WEB";
        }
        [WebMethod]
        public string circulo(double radio)
        {
            var resultado = radio * radio * 3.14;
            return resultado.ToString();

        }

        [WebMethod]
        public string cuadrado(int lado)
        {
            var resultado = lado * lado;
            return resultado.ToString();
        }


        [WebMethod]
        public string triangulo(int bases, int altura)
        {
            var resultado = (bases * altura) / 2;
            return resultado.ToString();
        }




    }
}
