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
    public class JuegosController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        public JuegosController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/juego
        [HttpGet]
        public ActionResult<IEnumerable<Juego>> GetJuegoItems()
        {
            return _context.Juegos.ToList();
        }

        // GET: api/juego/5
        [HttpGet("{id}")]
        public ActionResult<Juego> GetJuegoItem(int id)
        {
            var juegoItem = _context.Juegos.Find(id);
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

        // PUT: api/juego/5
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

        // DELETE: api/juego/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteJuegoItem(int id)
        {
            var juegoItem = _context.Tienda.Find(id);
            if (juegoItem == null)
            {
                return NotFound();
            }
            _context.Tienda.Remove(juegoItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}