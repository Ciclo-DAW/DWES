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
    public class ConsolasController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        public ConsolasController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/consolas
        [HttpGet]
        public ActionResult<IEnumerable<Consola>> GetConsolaItems()
        {
            return _context.Consolas.ToList();
        }

        // GET: api/consolas/5
        [HttpGet("{id}")]
        public ActionResult<Consola> GetConsolaItem(int id)
        {
            //var consolaItem = _context.Consolas.Find(id);
            var consolaItem = _context.Consolas
                .Include(c => c.Marca)
                    .ThenInclude(m => m.Perifericos)
                .Include(c => c.Tienda)
                    .ThenInclude(t => t.Consolas)
                .FirstOrDefault(m => m.ID == id);
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