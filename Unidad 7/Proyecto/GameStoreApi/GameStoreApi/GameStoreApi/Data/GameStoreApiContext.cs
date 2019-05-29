using GameStoreApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.Data
{
    public class GameStoreApiContext : IdentityDbContext<IdentityUser>
    {
        public GameStoreApiContext(DbContextOptions<GameStoreApiContext> options) :
        base(options)
        { }

        public DbSet<Consola> Consolas { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Periferico> Perifericos { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
    }
}
