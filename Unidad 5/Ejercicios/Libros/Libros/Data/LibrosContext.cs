using Libros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libros.Data
{
    public class LibrosContext : DbContext
    {
        public LibrosContext(DbContextOptions<LibrosContext> options) : base(options) { } //Constructor que recibe los parámetros de conexión definidos en appsettings.json

        public DbSet<Autor> Autores { get; set; } //Tabla Autores
        public DbSet<Libro> Libros { get; set; } //Tabla Libros
    }
}
