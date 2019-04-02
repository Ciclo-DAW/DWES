using CIFPACarballeiraWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIFPACarballeiraWeb.Data
{
    public class CIFPACarballeiraContext : IdentityDbContext<IdentityUser>
    {
        public CIFPACarballeiraContext(DbContextOptions<CIFPACarballeiraContext> options) : base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Material> Materiales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ubicacion>().ToTable("Ubicaciones");
            modelBuilder.Entity<Material>().ToTable("Materiales");
        }
    }
}
