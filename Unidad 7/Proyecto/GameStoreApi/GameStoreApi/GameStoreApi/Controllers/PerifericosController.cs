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
    public class PerifericosController : ControllerBase
    {
        private readonly GameStoreApiContext _context;
        public PerifericosController(GameStoreApiContext context)
        {
            _context = context;

        }
        // GET: api/perifericos
        [HttpGet]
        public ActionResult<IEnumerable<Periferico>> GetPerifericoItems()
        {
            return _context.Perifericos.ToList();
        }

        // GET: api/perifericos/5
        [HttpGet("{id}")]
        public ActionResult<Periferico> GetPerifericoItem(int id)
        {
            var perifericoItem = _context.Perifericos.Find(id);
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