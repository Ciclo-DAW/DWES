using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<Tarea> GetTodoItem(long id)
        {
            var todoItem = _context.Tareas.Find(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }
    }
}