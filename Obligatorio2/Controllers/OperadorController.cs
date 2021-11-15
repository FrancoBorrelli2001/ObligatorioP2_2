﻿using Microsoft.AspNetCore.Mvc;
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
            return View();
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

            return View(s.GetClientes());

        }


        public IActionResult Estadisticas()
        {
            return View();
        }


        public IActionResult ListarActividadesSegunLugar()
        {
            ViewBag.Lugares = s.GetLugares();
            return View();
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
            ViewBag.Categorias = s.GetCategorias();
            return View();
        }

        [HttpPost]

        public IActionResult VerActividadesEntreFechasYCategoria(DateTime fecha1, DateTime fecha2, string nombreCategoria)
        {
            ViewBag.Categorias = s.GetCategorias();
            ViewBag.LA = s.ListarActividadesSegunCategoriaYFecha(nombreCategoria,fecha1, fecha2);
            ViewBag.Categoria = nombreCategoria;
            ViewBag.Fecha1 = fecha1;
            ViewBag.Fecha2 = fecha2;

            return View();
        }

        public IActionResult ComprasMayorValor()
        {
            List<Compra> resu = s.ObtenerComprasMayorValor();
            return View(resu);

        }

    }
}