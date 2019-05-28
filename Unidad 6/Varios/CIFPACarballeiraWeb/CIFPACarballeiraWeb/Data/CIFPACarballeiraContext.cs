using Microsoft.EntityFrameworkCore;
using CIFPACarballeiraWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CIFPACarballeiraWeb.Data
{
    public class CIFPACarballeiraContext : IdentityDbContext<IdentityUser>
    {
        public CIFPACarballeiraContext(DbContextOptions<CIFPACarballeiraContext> options) :
            base(options)
        { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Material> Materiales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ubicacion>().ToTable("Ubicaciones");
            modelBuilder.Entity<Material>().ToTable("Materiales");
            modelBuilder.Entity<IdentityUser>().ToTable("Usuarios");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UsuariosClaims");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UsuariosRoles");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UsuariosLogins");
        }
    }
}
