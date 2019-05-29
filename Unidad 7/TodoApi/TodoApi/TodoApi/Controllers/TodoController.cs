using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoApiContext _context;
        public TodoController(TodoApiContext context)
        {
            _context = context;
            if (_context.Tareas.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                _context.Tareas.Add(new Tarea { Descripcion = "Item1" });
                _context.SaveChanges();
            }


        }

        // GET: api/Todo
        [HttpGet]
        public ActionResult<IEnumerable<Tarea>> GetTodoItems()
        {
            return _context.Tareas.ToList();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public ActionResult<Tarea> GetTodoItem(int id)
        {
            var todoItem = _context.Tareas.Find(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }

        // POST: api/Todo
        [HttpPost]
        public ActionResult<Tarea> PostTodoItem(Tarea item)
        {
            _context.Tareas.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public IActionResult PutTodoItem(int id, Tarea item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTodoItem(int id)
        {
            var todoItem = _context.Tareas.Find(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            _context.Tareas.Remove(todoItem);
            _context.SaveChanges();
            return NoContent();
        }
    }
}