using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameStoreApi.Data;
using GameStoreApi.DTO;
using GameStoreApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerifericosController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        private static readonly Expression<Func<Periferico, PerifericoDto>> AsPerifericoDto =
            p => new PerifericoDto
            {
                ID = p.ID,
                Marca = new MarcaDto
                {
                    ID = p.Marca.ID,
                    Nombre = p.Marca.Nombre,
                },
                Modelo = p.Modelo,
                Precio = p.Precio,
                Tienda = new TiendaDto
                {
                    ID = p.Tienda.ID,
                    Nombre = p.Tienda.Nombre,
                    Direccion = p.Tienda.Direccion
                }
            };
        public PerifericosController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/perifericos
        [HttpGet]
        public ActionResult<IEnumerable<PerifericoDto>> GetPerifericoItems()
        {


            return _context.Perifericos
                .Select(AsPerifericoDto)
                .ToList();
        }

        // GET: api/perifericos/5
        [HttpGet("{id}")]
        public ActionResult<PerifericoDto> GetPerifericoItem(int id)
        {
            //var perifericoItem = _context.Perifericos
            //    .Include(p => p.Marca)
            //    .Include(p => p.Tienda)
            //    .FirstOrDefault(p => p.ID == id);

            var perifericoItem = _context.Perifericos
                .Where(p => p.ID == id)
                .Select(AsPerifericoDto)
                .FirstOrDefault();   

            if (perifericoItem == null)
            {
                return NotFound();
            }
            return perifericoItem;
        }

        // GET: api/perifericos/5/details
        [HttpGet("{id}/details")]
        public ActionResult<PerifericoDetailsDto> GetPerifericoDetailsItem(int id)
        {
            var perifericoItem = _context.Perifericos
                .Include(p => p.Marca)
                .Include(p => p.Tienda)
                .Where(p => p.ID == id)
                .Select(p => new PerifericoDetailsDto
                {
                    ID = p.ID,
                    Marca = new MarcaDto
                    {
                        ID = p.Marca.ID,
                        Nombre = p.Marca.Nombre,
                    },
                    Modelo = p.Modelo,
                    Descripcion = p.Descripcion,
                    Cantidad = p.Cantidad,
                    Precio = p.Precio,
                    FechaSalida = p.FechaSalida,
                    Estado = p.Estado,
                    Tipo = p.Tipo,
                    Tienda = new TiendaDto
                    {
                        ID = p.Tienda.ID,
                        Nombre = p.Tienda.Nombre,
                        Direccion = p.Tienda.Direccion
                    }
                })
                .FirstOrDefault();

            if (perifericoItem == null)
            {
                return NotFound();
            }
            return perifericoItem;
        }

        // POST: api/perifericos
        [HttpPost]
        [Authorize]
        public ActionResult<Periferico> PostPerifericoItem(Periferico item)
        {
            _context.Perifericos.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPerifericoItem), new { id = item.ID }, item);
        }

        // PUT: api/perifericos/5
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult PutPerifericoItem(int id, Periferico item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/perifericos/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeletePerifericoItem(int id)
        {
            var perifericoItem = _context.Perifericos.Find(id);
            if (perifericoItem == null)
            {
                return NotFound();
            }
            _context.Perifericos.Remove(perifericoItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}