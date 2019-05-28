using Concesionario_UD6.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.Data
{
    public class ConcesionarioContext : IdentityDbContext<IdentityUser>
    {
        public ConcesionarioContext(
            DbContextOptions<ConcesionarioContext> options) :
            base(options) { }

        public DbSet<Concesionario> Concesionarios { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ubicacion>().ToTable("Ubicaciones");
            modelBuilder.Entity<Vehiculo>().ToTable("Vehiculos");
        }
    }
}
