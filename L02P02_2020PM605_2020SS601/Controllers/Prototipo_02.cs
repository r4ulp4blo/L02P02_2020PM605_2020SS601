using Microsoft.AspNetCore.Mvc;
using L02P02_2020PM605_2020SS601.Models;
using System.Linq;


namespace L02P02_2020PM605_2020SS601.Controllers
{
    public class Prototipo_02 : Controller
    {
        private readonly libreriaDbContext _libreriaDbContext;

        public Prototipo_02(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }


        public IActionResult Index(string autorSeleccionado)
        {
            // Obtener los libros del autor seleccionado y sus nombres
            var librosPorAutor = (from libro in _libreriaDbContext.libros
                                  join autor in _libreriaDbContext.autores
                                  on libro.id_autor equals autor.id
                                  where autor.id == libro.id_autor && autor.autor == autorSeleccionado
                                  select new LibroPorAutorModel
                                  {
                                      NombreLibro = libro.nombre,
                                      DescripcionLibro = libro.descripcion,
                                      PrecioLibro = libro.precio,
                                      NombreAutor = autor.autor
                                  }).ToList();

            // Pasar los libros y el nombre del autor seleccionado a la vista
            ViewData["LibrosPorAutor"] = librosPorAutor;
            ViewData["AutorSeleccionado"] = autorSeleccionado;

            return View();
        }
    }
}
