using Microsoft.AspNetCore.Mvc;
using L02P02_2020PM605_2020SS601.Models;


namespace L02P02_2020PM605_2020SS601.Controllers
{
    public class Prototipo_01 : Controller
    {
        private readonly libreriaDbContext _libreriaDbContext;

        public Prototipo_01 (libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        [HttpPost]
        public IActionResult SeleccionarAutor(string nombreAutor)
        {
            return RedirectToAction("Index", "Prototipo_02", new { autorSeleccionado = nombreAutor });
        }

        public IActionResult Index()
        {
            var listaNombresAutores = (from libro in _libreriaDbContext.libros
                join autor in _libreriaDbContext.autores on libro.id_autor equals autor.id
                select new
                {
                    nombreAutor = autor.autor
                }
            );

            ViewData["listaNombresAutores"] = listaNombresAutores.ToList();

            return View();
        }

        
    }
}
