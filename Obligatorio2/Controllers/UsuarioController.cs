using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorio2.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            Usuario buscado = s.LoginUsuario(email, password);
            if (buscado != null)
            {
                //COMO GUARDO UN OBJETO DE SESION
                //HttpContext.Session.SetObject("ClasePersona", buscado);
                ViewBag.msg = "Usuario ingresado";
            }
            else
            {
                ViewBag.msg = "Error";
            }
          
            return View();
        }



        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Registro(string nombre,string apellido,string email,DateTime fechaNacimiento,string nombreUsuario,string password)
        {
            Usuario u = s.AltaUsuario(nombre, apellido,email,fechaNacimiento, nombreUsuario,password);
            if (u == null)
            {
                ViewBag.msg="Error en el registro";
            }
            else
            {
                ViewBag.msg = "Registro exitoso!";

            }
            return View();
        }

      

    }


}
