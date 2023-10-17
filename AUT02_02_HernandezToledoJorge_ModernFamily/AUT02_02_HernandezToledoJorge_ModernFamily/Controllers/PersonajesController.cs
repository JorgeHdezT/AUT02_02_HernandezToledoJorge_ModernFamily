using AUT02_02_HernandezToledoJorge_ModernFamily.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AUT02_02_HernandezToledoJorge_ModernFamily.Controllers
{
    public class PersonajesController : Controller
    {

        //Crear una lista de personajes por defecto para luego ir agregandole elementos.
        public static List<Personaje> ListaPersonajes = new List<Personaje>
        {
            new Personaje { Id = 1, Name="Paco", Family="Toronto", NChildren = 1 },
            new Personaje { Id = 2, Name="Pedro", Family="Toronto", NChildren = 1 },
            new Personaje { Id = 3, Name="Pepe", Family="Toronto", NChildren = 1 }
        };
        public IActionResult Index()
        {
            return View(ListaPersonajes);
        }

        [HttpGet]
        public IActionResult CrearPersonaje()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearPersonaje(Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                personaje.Id = ListaPersonajes.Count + 1;
                ListaPersonajes.Add(personaje);
            }
            return View(personaje);
        }

    }
}
