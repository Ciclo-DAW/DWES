using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext(DbContextOptions<GameStoreContext> options) :
        base(options){ }

        public DbSet<Consola> Consolas { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Periferico> Perifericos { get; set; }
    }
}
