using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Obligatorio2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio2.Controllers
{
    public class OperadorController : Controller
    {

        Sistema s = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout(string n)
        {
            HttpContext.Session.Clear();
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult VerComprasEntreFechas()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost]
        public IActionResult VerComprasEntreFechas(DateTime fecha1, DateTime fecha2)
        {
            List<Compra> ComprasEntreFechas = s.ListarComprasSegunFechas(fecha1, fecha2);

            ViewBag.LC = ComprasEntreFechas;
            ViewBag.PrecioTotal = s.ObtenerPrecioTotalDeCompras(ComprasEntreFechas);
            ViewBag.Fecha1 = fecha1;
            ViewBag.Fecha2 = fecha2;
            return View();
        }

        public IActionResult VerClientes()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                return View(s.GetClientes());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult Estadisticas()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        public IActionResult ListarActividadesSegunLugar()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                ViewBag.Lugares = s.GetLugares();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult ListarActividadesSegunLugar(string lugar)
        {
            ViewBag.Lugares = s.GetLugares();
            ViewBag.LA = s.ObtenerActividadesSegunLugar(lugar);
            ViewBag.Lugar = lugar;
            return View();
        }

        public IActionResult VerActividadesEntreFechasYCategoria()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                ViewBag.Categorias = s.GetCategorias();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult VerActividadesEntreFechasYCategoria(DateTime fecha1, DateTime fecha2, string nombreCategoria)
        {
            ViewBag.Categorias = s.GetCategorias();
            ViewBag.LA = s.ListarActividadesSegunCategoriaYFecha(nombreCategoria, fecha1, fecha2);
            ViewBag.Categoria = nombreCategoria;
            ViewBag.Fecha1 = fecha1;
            ViewBag.Fecha2 = fecha2;

            return View();
        }

        public IActionResult ComprasMayorValor()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                List<Compra> resu = s.ObtenerComprasMayorValor();
                return View(resu);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Otros()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult CambiarPrecioBaseActividades()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                ViewBag.PrecioBaseActual = s.GetPrecioBaseActividad();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult CambiarPrecioBaseActividades(double nuevoPrecio)
        {
            if (s.SetPrecioBaseActividad(nuevoPrecio))
            {
                ViewBag.msg = "Cambio Realizado";
            }
            else
            {
                ViewBag.msg = "El nuevo precio debe ser menor";
            }

            ViewBag.PrecioBaseActual = s.GetPrecioBaseActividad();
            return View();
        }

        //Cambia el Aforo Máximo
        public IActionResult CambiarAforoMaximo()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                ViewBag.AforoActual = s.GetAforoMaximo();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult CambiarAforoMaximo(int nuevoAforo)
        {
            if (s.SetAforoMaximo(nuevoAforo))
            {
                ViewBag.msg = "Aforo Cambiado!";
            }
            else
            {
                ViewBag.msg = "El nuevo aforo debe estar entre 0 y 100";
            }
            ViewBag.AforoActual = s.GetAforoMaximo();
            return View();
        }


        //Cambia el precio de las butacas
        public IActionResult CambiarPrecioButacas()
        {
            if (HttpContext.Session.GetString("RolLogueado") == "Operador")
            {
                ViewBag.PrecioButacasActual = s.GetPrecioButacas();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult CambiarPrecioButacas(double nuevoPrecio)
        {
            if (s.SetPrecioButacas(nuevoPrecio))
            {
                ViewBag.msg = "Precio cambiado!";
            }
            else
            {
                ViewBag.msg = "El precio debe ser positivo";
            }
            ViewBag.PrecioButacasActual = s.GetPrecioButacas();
            return View();
        }
    }
}