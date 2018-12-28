using PruebasUnitarias.Models;
using PruebasUnitarias.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebasUnitarias.Controllers
{
    public class HomeController : Controller
    {
        private IPersonasService personasService;
       
        public HomeController(IPersonasService personasService)
        {
            this.personasService = personasService;
        }

        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult CrearPesona(Persona persona)
        {
            if (!personasService.EsValida(persona)){

                ViewBag.MensajeError = personasService.Errores[0];

                return View();
            }

            return View();

        }
    }
}