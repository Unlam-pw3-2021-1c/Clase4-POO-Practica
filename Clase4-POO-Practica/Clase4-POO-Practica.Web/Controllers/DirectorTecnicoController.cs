using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase4_POO_Practica.Web.Controllers
{
    public class DirectorTecnicoController : Controller
    {
        [HttpGet]
        public IActionResult Crear()
        {
            ViewData["Arqueros"] = Datos.Arqueros;
            ViewData["Delanteros"] = Datos.Delanteros;
            return View();
        }

        [HttpPost]
        public IActionResult Crear(DirectorTecnico dt)
        {
            dt.Arquero = Datos.Arqueros.FirstOrDefault(o=> o.Id == dt.Arquero.Id);
            dt.Delantero1 = Datos.Delanteros.FirstOrDefault(o=> o.Id == dt.Delantero1.Id);
            dt.Delantero2 = Datos.Delanteros.FirstOrDefault(o=> o.Id == dt.Delantero2.Id);

            Datos.DirectoresTecnicos.Add(dt);
            return Redirect("/DirectorTecnico/Crear");
        }
    }
}
