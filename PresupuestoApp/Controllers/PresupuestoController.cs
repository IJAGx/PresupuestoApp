using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PresupuestoApp.Models;
using System;

namespace PresupuestoApp.Controllers
{
    public class PresupuestoController : Controller
    {
        private static PresupuestoViewModel presupuesto = new PresupuestoViewModel();

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Iniciar(string nombreUsuario)
        {
            presupuesto = new PresupuestoViewModel { NombreUsuario = nombreUsuario };
            return RedirectToAction("Paso1");
        }

        public IActionResult Paso1() => View(presupuesto);

        [HttpPost]
        public IActionResult Paso1(PresupuestoViewModel model)
        {
            presupuesto.IngresoPrevistoPrincipal = model.IngresoPrevistoPrincipal;
            presupuesto.IngresoPrevistoAdicional = model.IngresoPrevistoAdicional;
            presupuesto.IngresoRealPrincipal = model.IngresoRealPrincipal;
            presupuesto.IngresoRealAdicional = model.IngresoRealAdicional;
            return RedirectToAction("Paso2");
        }

        public IActionResult Paso2() => View(presupuesto);

        [HttpPost]
        public IActionResult Paso2(PresupuestoViewModel model)
        {
            presupuesto.Alquiler = model.Alquiler;
            presupuesto.Electricidad = model.Electricidad;
            presupuesto.Agua = model.Agua;
            presupuesto.Gas = model.Gas;
            presupuesto.AyudanteHogar = model.AyudanteHogar;
            presupuesto.Colegio = model.Colegio;
            presupuesto.DespensaFija = model.DespensaFija;
            presupuesto.InternetHogar = model.InternetHogar;
            presupuesto.Telefono = model.Telefono;
            return RedirectToAction("Paso3");
        }

        public IActionResult Paso3() => View(presupuesto);

        [HttpPost]
        public IActionResult Paso3(PresupuestoViewModel model)
        {
            presupuesto.Ahorros = model.Ahorros;
            presupuesto.Estudios = model.Estudios;
            presupuesto.Peluqueria = model.Peluqueria;
            presupuesto.Gimnasio = model.Gimnasio;
            presupuesto.TransporteLaboral = model.TransporteLaboral;
            presupuesto.TransporteExtra = model.TransporteExtra;
            presupuesto.PagoVehiculo = model.PagoVehiculo;
            presupuesto.Combustible = model.Combustible;
            presupuesto.MesadaPadres = model.MesadaPadres;
            presupuesto.MesadaHijos = model.MesadaHijos;
            return RedirectToAction("Paso4");
        }

        public IActionResult Paso4() => View(presupuesto);

        [HttpPost]
        public IActionResult Paso4(PresupuestoViewModel model)
        {
            presupuesto.Prestamo1 = model.Prestamo1;
            presupuesto.Prestamo2 = model.Prestamo2;
            presupuesto.PrestamoEstudiantil = model.PrestamoEstudiantil;
            presupuesto.TarjetaCredito1 = model.TarjetaCredito1;
            presupuesto.TarjetaCredito2 = model.TarjetaCredito2;
            return RedirectToAction("Paso5");
        }

        public IActionResult Paso5() => View(presupuesto);

        [HttpPost]
        public IActionResult Paso5(PresupuestoViewModel model)
        {
            presupuesto.Streaming = model.Streaming;
            presupuesto.Salidas = model.Salidas;
            presupuesto.Restaurantes = model.Restaurantes;
            presupuesto.DespensaExtra = model.DespensaExtra;
            return RedirectToAction("Resultado");
        }

        public IActionResult Resultado() => View(presupuesto);

    }
}
