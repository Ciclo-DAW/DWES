using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuguetylandiaWeb.Models
{
    public enum Edad
    {
        [Display(Name = "0 - 12 meses")]
        Bebes,
        [Display(Name = "1 - 2 años")]
        BebesMayores,
        [Display(Name = "+3 años")]
        NenosPequenos,
        [Display(Name = "+8 años")]
        NenosGrandes
    }
    public enum Tipo
    {
        [Display(Name = "Muñecas")]
        Munecas,
        [Display(Name = "Peluches")]
        Peluches,
        [Display(Name = "Construcción")]
        Construccion,
        [Display(Name = "Puzzles")]
        Puzzles,
        [Display(Name = "Educativos")]
        Educativos,
        [Display(Name = "Juegos de mesa")]
        JuegosMesa,
        [Display(Name = "Manualidades")]
        Manualidades,
        [Display(Name = "Juguetes musicales")]
        JuegosMusicales,
        [Display(Name = "Primera Infancia")]
        PrimeraInfancia
    }
}
