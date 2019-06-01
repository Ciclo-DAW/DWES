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
    public class JuegosController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        private static readonly Expression<Func<Juego, JuegoDto>> AsJuegoDto =
            j => new JuegoDto
            {
                ID = j.ID,
                Nombre = j.Nombre,
                Modelo = j.Modelo,
                Precio = j.Precio,
                Tienda = new TiendaDto
                {
                    ID = j.Tienda.ID,
                    Nombre = j.Tienda.Nombre,
                    Direccion = j.Tienda.Direccion
                }
            };
        public JuegosController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/juegos
        [HttpGet]
        public ActionResult<IEnumerable<JuegoDto>> GetJuegoItems()
        {

            //Esto lo hice un poco por probar cosas nuevas
            return _context.Juegos
                .Include(j => j.Tienda)
                .Select(AsJuegoDto)
                .ToList();
        }

        // GET: api/juegos/5
        [HttpGet("{id}")]
        public ActionResult<JuegoDto> GetJuegoItem(int id)
        {
            
            var juegoItem = _context.Juegos
                .Include(j => j.Tienda)
                .Where(j => j.ID == id)
                .Select(AsJuegoDto)
                .FirstOrDefault();

            if (juegoItem == null)
            {
                return NotFound();
            }
            return juegoItem;
        }

        // GET: api/juegos/5/details
        [HttpGet("{id}/details")]
        public ActionResult<JuegoDetailsDto> GetJuegoDetailsItem(int id)
        {
            var juegoItem = _context.Juegos
                .Include(j => j.Tienda)
                .Where(j => j.ID == id)
                .Select(j => new JuegoDetailsDto
                {
                    ID = j.ID,
                    Nombre = j.Nombre,
                    Modelo = j.Modelo,
                    Descripcion = j.Descripcion,
                    Cantidad = j.Cantidad,
                    Precio = j.Precio,
                    FechaSalida = j.FechaSalida,
                    Estado = j.Estado,
                    Genero = j.Genero,
                    Tienda = new TiendaDto
                    {
                        ID = j.Tienda.ID,
                        Nombre = j.Tienda.Nombre,
                        Direccion = j.Tienda.Direccion
                    }
                })
                .FirstOrDefault();

            if (juegoItem == null)
            {
                return NotFound();
            }
            return juegoItem;
        }

        // POST: api/juego
        [HttpPost]
        [Authorize]
        public ActionResult<Juego> PostJuegoItem(Juego item)
        {
            _context.Juegos.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetJuegoItem), new { id = item.ID }, item);
        }

        // PUT: api/juegos/5
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult PutJuegoItem(int id, Juego item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/juegos/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteJuegoItem(int id)
        {
            var juegoItem = _context.Juegos.Find(id);
            if (juegoItem == null)
            {
                return NotFound();
            }
            _context.Juegos.Remove(juegoItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}