using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
