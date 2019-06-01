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
        public ActionResult<Tienda> GetTiendaItem(int id)
        {
            var tiendaItem = _context.Tienda.Find(id);
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