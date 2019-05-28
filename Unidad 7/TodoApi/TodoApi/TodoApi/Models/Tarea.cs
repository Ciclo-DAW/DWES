using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public bool Realizada { get; set; }
    }
}
