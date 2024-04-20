﻿using Microsoft.EntityFrameworkCore;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions options): base(options) { }

        public DbSet<autores> autores { get; set; }
        public DbSet<categorias> categorias { get; set; }
        public DbSet<clientes> clientes { get; set; }
        public DbSet<libros> libros { get; set; }
        public DbSet<pedido_detalle> pedido_detalle { get; set; }
        public DbSet<comentarios_libros> comentarios_libros { get; set; }
        public DbSet<pedido_encabezado> pedido_encabezado { get; set; }

    }
}
