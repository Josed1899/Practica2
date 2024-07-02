using Practica2.Entidades;
using Practica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2.Controllers
{
    public class HomeController : Controller
    {
        VendedoresModel vendedoresM = new VendedoresModel();
        VehiculosModel vehiculosM = new VehiculosModel();

        // ACCION VENDEDORES/INDEX
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Vendedores entidad)
        {
            if (ModelState.IsValid)
            {
                var respuesta = vendedoresM.RegistrarVendedores(entidad);
                if (respuesta)
                {
                    ViewBag.Message = "Vendedor registrado exitosamente.";
                }
                else
                {
                    ModelState.AddModelError("Cedula", "La cédula ya está registrada.");
                }
            }

            return View();
        }

        //ACCION HOME donde se abre el programa
        public ActionResult Home()
        {
            return View();
        }

        //ACCION DE VEHICULOS
        [HttpGet]
        public ActionResult Vehiculos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Vehiculos(Vehiculos entidad)
        {
            string mensaje;
            var respuesta = vehiculosM.RegistrarVehiculos(entidad, out mensaje);
            ViewBag.Mensaje = mensaje;
            if (respuesta)
            {
                ViewBag.AlertClass = "alert-success";
            }
            else
            {
                ViewBag.AlertClass = "alert-danger";
            }
            return View();
        }

        [HttpGet]
        public ActionResult ConsultarVehiculos()
        {
            var respuesta = vehiculosM.ConsultarVehiculos();
            return View(respuesta);
        }
    }
}
