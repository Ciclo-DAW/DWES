using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.DTO
{
    public class MarcaDetailsDto
    {
        public int ID { get; set; }


        public string Nombre { get; set; }


        public List<ConsolaDto> Consolas { get; set; }

        public List<PerifericoDto> Perifericos { get; set; }
    }
}
