using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListaTareas.Models;

namespace ListaTareas.Data
{
    public class ListaTareasContext : DbContext
    {
        public ListaTareasContext(DbContextOptions<ListaTareasContext> options) : base(options) { }
        public DbSet<Tarea> Tareas { get; set; }  
    }
}
