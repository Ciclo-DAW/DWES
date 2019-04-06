using GameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.ViewModels
{
    public class TiendasViewModel
    {
        public List<Juego> Juegos { get; set; }
        public List<Periferico> Perifericos { get; set; }
        public List<Consola> Consolas { get; set; }
    }
}
