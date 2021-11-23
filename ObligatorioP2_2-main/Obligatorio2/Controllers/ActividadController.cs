using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Obligatorio2.Controllers
{
    public class ActividadController : Controller
    {
        Sistema s = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            List<Actividad> Actividades = s.GetActividades();
            return View(Actividades);
        }

        public IActionResult MeGusta(int id)
        {
            s.DarMG(id);
            return RedirectToAction("List");
        }

        public IActionResult Comprar(int id, string? msg)
        {
            ViewBag.Actividad = s.BuscarActividad(id);
            ViewBag.IdActividad = id;
            ViewBag.msg = msg;
            return View();
        }


        [HttpPost]
        public IActionResult Comprar(int idActividad, int cantEntradas)
        {
            Actividad act = s.BuscarActividad(idActividad);

            int? idUsuarioLogueado = HttpContext.Session.GetInt32("IdLogueado");
            Usuario usu = s.BuscarUsuario(idUsuarioLogueado);
            DateTime FechaHoraActual = DateTime.Now;
            Compra compra = s.AltaCompra(act, cantEntradas, usu, FechaHoraActual);

            //Si se realiza la compra vuelve a llamar a al vista compra con un mensaje de "Compra Realizada"
            if (compra != null)
            {
                return RedirectToAction("Comprar", new
                {
                    id = idActividad,
                    msg = "Compra Realizada",

                });
            }
            else
            {
                return RedirectToAction("Comprar", new
                {
                    id = idActividad,
                    msg = "La cantidad de entradas debe ser mayor que 0",
                });
            }
        }
    }
}
