using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuguetylandiaWeb.Models;

namespace JuguetylandiaWeb.Data
{
    public class JuguetylandiaContext : DbContext
    {
        public JuguetylandiaContext(
            DbContextOptions<JuguetylandiaContext> options) :
base(options)
        { }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Juguete> Juguetes { get; set; }

    }
}