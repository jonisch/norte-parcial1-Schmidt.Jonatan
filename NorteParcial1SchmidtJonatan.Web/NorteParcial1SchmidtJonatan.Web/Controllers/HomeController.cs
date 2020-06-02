using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorteParcial1SchmidtJonatan.Web.Models;

namespace NorteParcial1SchmidtJonatan.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cosmo()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            var Constelacion = new Constelacion();
            Constelacion.Siglo = form["siglo"];
            Constelacion.Nombre = form["nombre"];
           
            Dominio.Add(Constelacion);

            return RedirectToAction("Cosmo");
        }



    }
}