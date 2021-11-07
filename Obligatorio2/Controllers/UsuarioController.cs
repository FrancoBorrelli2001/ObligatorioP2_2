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
            List<Usuario> USUARIOSC = s.GetUsuariosCliente();
            List<Usuario> USUARIOSSINIDENTIFICAR = s.GetUsuariosSinIdentificar();
            return View();
        }



        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Registro(string email, string password)
        {
            Usuario u = s.AltaUsuarioSinIdentificar(email, password);
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

        public IActionResult SerCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SerCliente(string nombre,string apellido,DateTime fechaNacimiento,string email,string nombreUsuario,string password)
        {
            Usuario resu = s.CambiarTipoUsuario(nombre, apellido, fechaNacimiento, email, nombreUsuario, password);
            if (resu != null)
            {
                ViewBag.msg = "Cambio a usuario de tipo cliente realizado!";
            }
            else
            {
                ViewBag.msg = "ERROR";

            }
            return View();
        }

    }


}
