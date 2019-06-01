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
    public class ConsolasController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        private static readonly Expression<Func<Consola, ConsolaDto>> AsConsolaDto =
            c => new ConsolaDto
            {
                ID = c.ID,
                Marca = new MarcaDto
                {
                    ID = c.Marca.ID,
                    Nombre = c.Marca.Nombre,
                },
                Modelo = c.Modelo,
                Precio = c.Precio,
                Tienda = new TiendaDto
                {
                    ID = c.Tienda.ID,
                    Nombre = c.Tienda.Nombre,
                    Direccion = c.Tienda.Direccion
                }
            };

        public ConsolasController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/consolas
        [HttpGet]
        public ActionResult<IEnumerable<ConsolaDto>> GetConsolaItems()
        {
            return _context.Consolas
                .Select(AsConsolaDto)
                .ToList();
        }

        // GET: api/consolas/5
        [HttpGet("{id}")]
        public ActionResult<ConsolaDto> GetConsolaItem(int id)
        {
            //var consolaItem = _context.Consolas.Find(id);
            //var consolaItem = _context.Consolas
            //    .Include(c => c.Marca)     
            //    .Include(c => c.Tienda)     
            //    .FirstOrDefault(c => c.ID == id);

            var consolaItem = _context.Consolas
                .Where(c => c.ID == id)
                .Select(AsConsolaDto)
                .FirstOrDefault();

            if (consolaItem == null)
            {
                return NotFound();
            }
            return consolaItem;
        }

        // GET: api/consolas/5/details
        [HttpGet("{id}/details")]
        public ActionResult<ConsolaDetailsDto> GetConsolaDetailsItem(int id)
        {
            //var consolaItem = _context.Consolas.Find(id);
            var consolaItem = _context.Consolas
                .Include(c => c.Marca)
                .Include(c => c.Tienda)
                .Where(c => c.ID == id)
                .Select(c => new ConsolaDetailsDto
                {
                    ID = c.ID,
                    Marca  = new MarcaDto
                    {
                        ID = c.Marca.ID,
                        Nombre = c.Marca.Nombre,
                    },
                    Modelo = c.Modelo,
                    Descripcion = c.Descripcion,
                    Cantidad = c.Cantidad,
                    Precio = c.Precio,
                    FechaSalida = c.FechaSalida,
                    Estado = c.Estado,
                    Tienda = new TiendaDto
                    {
                        ID = c.Tienda.ID,
                        Nombre = c.Tienda.Nombre,
                        Direccion = c.Tienda.Direccion
                    }
                })
                .FirstOrDefault();

            if (consolaItem == null)
            {
                return NotFound();
            }
            return consolaItem;
        }

        // POST: api/consolas
        [HttpPost]
        [Authorize]
        public ActionResult<Consola> PostConsolaItem(Consola item)
        {
            _context.Consolas.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetConsolaItem), new { id = item.ID }, item);
        }

        // PUT: api/consolas/5
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult PutConsolaItem(int id, Consola item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/consolas/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteConsolaItem(int id)
        {
            var consolaItem = _context.Consolas.Find(id);
            if (consolaItem == null)
            {
                return NotFound();
            }
            _context.Consolas.Remove(consolaItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}