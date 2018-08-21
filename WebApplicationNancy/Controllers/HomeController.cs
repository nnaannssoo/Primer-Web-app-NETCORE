using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationNancy.Models;

namespace WebApplicationNancy.Controllers
{
    public class HomeController : Controller
    {
        List<Mes> lista = new List<Mes>();
        public IActionResult test()
        {
            
            lista.Add(new Mes("enero",31));
            lista.Add(new Mes("febrero", 28));
            lista.Add(new Mes("marzo", 31));
            lista.Add(new Mes("abril", 30));
            lista.Add(new Mes("mayo", 31));
            lista.Add(new Mes("junio", 30));
            lista.Add(new Mes("julio", 31));
            ViewData ["info"]= lista;
            var suma = 0;
            var cont = 0;
            foreach(var mes in lista as List<Mes>)
            {
                suma += mes.dias;
                cont++;
            }
            ViewData["promedio"] = suma / cont;
            return View();
        }


        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to index";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
