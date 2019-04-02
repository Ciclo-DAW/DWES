using Libros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libros.ViewModels
{
    public class NuevoLibroViewModel
    {
        public Libro NuevoLibro { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
