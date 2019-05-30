using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.Models
{
    public enum GenerosJuego
    {
        [Display(Name = "Acción")]
        Accion,
        [Display(Name = "Aventura")]
        Aventura,
        [Display(Name = "Aventura Gráfica")]
        AventuraGrafica,
        [Display(Name = "Conducción")]
        Conduccion,
        [Display(Name = "Deportes")]
        Deportes,
        [Display(Name = "Estrategia")]
        Estrategia,
        [Display(Name = "Plataformas")]
        Plataformas,
        [Display(Name = "Puzzle")]
        Puzzle,
        [Display(Name = "RPG")]
        RPG
    }

    public enum TiposPeriferico
    {
        [Display(Name = "Mandos")]
        Mandos,
        [Display(Name = "Auriculares")]
        Auriculares,
        [Display(Name = "Altavoces")]
        Altavoces,
        [Display(Name = "Ratones")]
        Ratones,
        [Display(Name = "Teclados")]
        Teclados
    }

    public enum Estados
    {
        [Display(Name = "Nuevo")]
        Nuevo,
        [Display(Name = "Segunda Mano")]
        SegundaMano,
        [Display(Name = "Reacondicionado")]
        Reacondicionado
    }
}
