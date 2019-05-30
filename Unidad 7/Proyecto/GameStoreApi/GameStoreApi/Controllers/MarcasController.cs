using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreApi.Data;
using GameStoreApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        public MarcasController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/marcas
        [HttpGet]
        public ActionResult<IEnumerable<Marca>> GetMarcaItems()
        {
            return _context.Marca.ToList();
        }

        // GET: api/marcas/5
        [HttpGet("{id}")]
        public ActionResult<Marca> GetMarcaItem(int id)
        {
            var marcaItem = _context.Marca.Find(id);
            if (marcaItem == null)
            {
                return NotFound();
            }
            return marcaItem;
        }

        // POST: api/marcas
        [HttpPost]
        [Authorize]
        public ActionResult<Tienda> PostMarcaItem(Marca item)
        {
            _context.Marca.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMarcaItem), new { id = item.ID }, item);
        }

        // PUT: api/marcas/5
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult PutMarcaItem(int id, Marca item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/marcas/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteMarcaItem(int id)
        {
            var marcaItem = _context.Marca.Find(id);
            if (marcaItem == null)
            {
                return NotFound();
            }
            _context.Marca.Remove(marcaItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}