﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;


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
        public IActionResult Login(string nombreUsuario, string password)
        {
            Usuario buscado = s.LoginUsuario(nombreUsuario, password);
            if (buscado != null)
            {
                //Creacion de variables de sesion
                HttpContext.Session.SetString("NombreLogueado", buscado.nombre);
                if (buscado.rol == Usuario.Roles.Cliente)
                {
                    HttpContext.Session.SetString("RolLogueado", "Cliente");
                }
                else
                {
                    HttpContext.Session.SetString("RolLogueado", "Operador");
                }
                HttpContext.Session.SetInt32("IdLogueado", buscado.ID_usuario);
               
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                ViewBag.msg = "El usuario y/o la contraseña no son correctos";
                return View();
            }
        }


        public IActionResult VerCompras()
        {
            int? idCliente = HttpContext.Session.GetInt32("IdLogueado");
            List<Compra> compras = s.ObtenerComprasSegunCliente(idCliente);

            return View(compras);
        }


        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string nombre, string apellido, string email, DateTime fechaNacimiento, string nombreUsuario, string password)
        {
            Usuario u = s.AltaUsuario(nombre, apellido, email, fechaNacimiento, nombreUsuario, password);
            if (u == null)
            {
                ViewBag.msg = "Error en el registro, verifique los datos ingresados";
            }
            else
            {
                ViewBag.msg = "Registro exitoso!";
            }
            return View();
        }

        

        public IActionResult CancelarCompra(int id)
        {
            Compra compra = s.BuscarCompraACancelar(id);
            if (compra != null)
            {
                ViewBag.compra = s.BuscarCompraACancelar(id);
            }
            else
            {
                ViewBag.msg = "No se puede cancelar una actividad con menos de 24hs de anticipación.";
            }
            return View();
        }

        [HttpPost]
        public IActionResult CancelarCompra(int IdCompra, string n)
        {
            s.CancelarCompra(IdCompra);
            return RedirectToAction("VerCompras");
        }
    }
}