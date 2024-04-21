using Microsoft.AspNetCore.Mvc;
using L02P02_2020PM605_2020SS601.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace L02P02_2020PM605_2020SS601.Controllers
{
    public class Prototipo_03 : Controller
    {
        private readonly libreriaDbContext _libreriaDbContext;

        public Prototipo_03(libreriaDbContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        public IActionResult MostrarComentarios(string nombreLibroSeleccionado)
        {
            int? idLibro = _libreriaDbContext.libros
                .Where(libro => libro.nombre == nombreLibroSeleccionado)
                .Select(libro => libro.id)
                .FirstOrDefault();

            if (idLibro != null)
            {
                var comentarios = _libreriaDbContext.comentarios_libros
                    .Where(comentario => comentario.id_libro == idLibro)
                    .Select(comentario => new ComentariosPorLibroModel
                    {
                        comentario = comentario.comentarios,
                        usuario = comentario.usuario,
                        fecha = comentario.create_at
                    }).ToList();

                ViewBag.Comentarios = comentarios;

                return View();
            }
            else
            {
                return RedirectToAction("LibroNoEncontrado");
            }
        }


    }
}
