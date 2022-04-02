using System;
using System.Collections.Generic;
using System.IO;//se requiere para usar StreamWriter
using System.Linq;
using System.Web;
using System.Web.Hosting; // se requiere para usar HostingEnvironment

namespace Proyecto4.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string comentarios)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            //el método MapPath del objeto HostingEnvironment que nos devuelve la ruta donde se almacena nuestro proyecto
            archivo.WriteLine("Nombre:" + nombre + "<br>Comentarios:" + comentarios + "<hr>");
            //el método WriteLine permite escribir en el archivo
            archivo.Close();
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            //el método MapPath del objeto HostingEnvironment que nos devuelve la ruta donde se almacena nuestro proyecto
            string todo = archivo.ReadToEnd();
           // el método "ReadToEnd" recuperamos todos los caracteres almacenados en el archivo de texto
            archivo.Close();
            return todo;
        }
    }
}