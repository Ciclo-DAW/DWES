using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Libros.Data;
using Libros.Models;
using Libros.ViewModels;

namespace Libros.Controllers
{
    public class LibrosController : Controller
    {
        private readonly LibrosContext _context;

        public LibrosController(LibrosContext context)
        {
            _context = context;
        }

        // GET: Libros
        public async Task<IActionResult> Index()
        {
            var nuevoLibroViewModel = new NuevoLibroViewModel();
            nuevoLibroViewModel.NuevoLibro = new Libro();
            nuevoLibroViewModel.Libros = await _context.Libros.Include(l => l.Autor).ToListAsync();
            ViewData["AutorId"] = new SelectList(_context.Autores,"Id", "NombreCompleto", nuevoLibroViewModel.NuevoLibro.AutorId);

            return View(nuevoLibroViewModel);
        }

        // POST: Libros/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("NuevoLibro")]NuevoLibroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewModel.NuevoLibro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id",
            "NombreCompleto", viewModel.NuevoLibro.AutorId);
            return View(viewModel);
        }

        // GET: Libros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros
                .Include(l => l.Autor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

     
        
        // GET: Libros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros
                .Include(l => l.Autor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibroExists(int id)
        {
            return _context.Libros.Any(e => e.Id == id);
        }
    }
}
