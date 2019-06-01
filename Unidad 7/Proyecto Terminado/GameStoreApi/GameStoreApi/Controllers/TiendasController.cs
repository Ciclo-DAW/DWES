using System;
using System.Collections.Generic;
using System.Linq;
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
    public class TiendasController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        public TiendasController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/tiendas
        [HttpGet]
        public ActionResult<IEnumerable<TiendaDto>> GetTiendaItems()
        {
            return _context.Tienda
                .Select(t => new TiendaDto
                {
                    ID = t.ID,
                    Nombre = t.Nombre,
                    Direccion = t.Direccion
                })
                .ToList();
        }

        // GET: api/tiendas/5
        [HttpGet("{id}")]
        public ActionResult<TiendaDto> GetTiendaItem(int id)
        {
            var tiendaItem = _context.Tienda
                .Where(t => t.ID == id)
                .Select(t => new TiendaDto         
                {
                    ID = t.ID,
                    Nombre = t.Nombre,
                    Direccion = t.Direccion
                })
                .FirstOrDefault();
            if (tiendaItem == null)
            {
                return NotFound();
            }
            return tiendaItem;
        }

        // GET: api/tiendas/5/details
        [HttpGet("{id}/details")]
        public ActionResult<TiendaDetailsDto> GetTiendaDetailsItem(int id)
        {
            var tiendaItem = _context.Tienda
                 .Where(t => t.ID == id)
                 .Select(t => new TiendaDetailsDto
                 {
                     ID = t.ID,
                     Nombre = t.Nombre,
                     Direccion = t.Direccion,
                     Consolas = t.Consolas.Select(c => new ConsolaDto
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
                     }).ToList(),
                     Perifericos = t.Perifericos.Select(p => new PerifericoDto
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
                     }).ToList(),
                     Juegos = t.Juegos.Select(j => new JuegoDto
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
                     }).ToList()
                 })
                 .FirstOrDefault();
            if (tiendaItem == null)
            {
                return NotFound();
            }
            return tiendaItem;
        }

        // POST: api/tiendas
        [HttpPost]
        [Authorize]
        public ActionResult<Tienda> PostTiendaItem(Tienda item)
        {
            _context.Tienda.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTiendaItem), new { id = item.ID }, item);
        }

        // PUT: api/tiendas/5
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult PutTiendaItem(int id, Tienda item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/tiendas/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteTiendaItem(int id)
        {
            var tiendaItem = _context.Tienda.Find(id);
            if (tiendaItem == null)
            {
                return NotFound();
            }
            _context.Tienda.Remove(tiendaItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}