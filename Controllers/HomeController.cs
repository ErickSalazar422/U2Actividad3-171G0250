using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using U2Actividad3_171G0250.Models;
using U2Actividad3_171G0250.Models.ViewModels;

namespace U2Actividad3_171G0250.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult peliculas()
        {
            pixarContext context = new pixarContext();
            var peliculas = context.Pelicula.OrderBy(x => x.Nombre);
            return View( peliculas);
        }
        public IActionResult cortos()
        {
            DatosCortoViewModel vm = new DatosCortoViewModel();
            pixarContext context = new pixarContext();

            var cat = context.Categoria.Include(x => x.Cortometraje)
           .Select(x => new DatosCortoViewModel { Nombre = x.Nombre, Cortometraje = x.Cortometraje });

            

            return View(cat);


           

            }
        [Route("/Corto/{id}")]
        public IActionResult CortoElegido(string id)
        {
            pixarContext context = new pixarContext();

            var nombre = id.Replace("-"," ");
            var cortometraje = context.Cortometraje.FirstOrDefault(x => x.Nombre.ToLower() == nombre);
           if(cortometraje==null)
            {
                return RedirectToAction("cortos");
            }
            else
            {
                return View(cortometraje);

            }

        }


        [Route("/Pelicula/{id}")]
        public IActionResult PeliculaElegida(string id)
        {
            var nombre = id.Replace("-", " ").ToUpper();
            pixarContext context = new pixarContext();
            var idper = context.Apariciones.OrderBy(x => x.IdPersonaje);

            var pelicula = context.Pelicula.Include(x=> x.Apariciones).ThenInclude(x=>x.IdPersonajeNavigation).FirstOrDefault(x => x.Nombre.ToUpper() == nombre);
            if (pelicula==null)
            { return RedirectToAction("Index"); }
            else
            {
                datospeliViewModel vm = new datospeliViewModel();
                vm.idp = pelicula.Id;
                vm.Nombre = pelicula.Nombre;
                vm.NombreOr = pelicula.NombreOriginal;
                vm.Año = pelicula.FechaEstreno;
                vm.descripcion = pelicula.Descripción;
                   
                vm.Apariciones = pelicula.Apariciones.OrderBy(x => x.IdPersonajeNavigation.Id).ThenBy(x=>x.IdPersonajeNavigation.Nombre)
                    .GroupBy(x => x.IdPersonajeNavigation.Id).Select(x => x).ToArray();







                return View(vm);


            }

        }



    }
}
