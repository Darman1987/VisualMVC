using Proyecto4.Models; //requerida para usar la clase creada en Modelos LibroVisitas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioVisita()
        {
            return View();
        }

        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();  //obtener datos enviados por post
            string comentarios = Request.Form["comentarios"].ToString();
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }

        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            //Mediante el diccionario ViewData podemos pasar datos a la vista, creamos una entrada en el diccionario
            //y le asignamos el string recuperado desde el "Modelo":
            return View();
        }
    }
}