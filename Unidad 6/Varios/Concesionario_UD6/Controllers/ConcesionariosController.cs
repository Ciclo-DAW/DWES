using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Concesionario_UD6.Data;
using Concesionario_UD6.Models;
using Microsoft.AspNetCore.Authorization;

namespace Concesionario_UD6.Controllers
{
    [Authorize]
    public class ConcesionariosController : Controller
    {
        private readonly ConcesionarioContext _context;

        public ConcesionariosController(ConcesionarioContext context)
        {
            _context = context;
        }

        // GET: Concesionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Concesionarios.ToListAsync());
        }

        // GET: Concesionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concesionario = await _context.Concesionarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (concesionario == null)
            {
                return NotFound();
            }

            return View(concesionario);
        }

        // GET: Concesionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Concesionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Direccion,Telefono")] Concesionario concesionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concesionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concesionario);
        }

        // GET: Concesionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concesionario = await _context.Concesionarios.FindAsync(id);
            if (concesionario == null)
            {
                return NotFound();
            }
            return View(concesionario);
        }

        // POST: Concesionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Direccion,Telefono")] Concesionario concesionario)
        {
            if (id != concesionario.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concesionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcesionarioExists(concesionario.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(concesionario);
        }

        // GET: Concesionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concesionario = await _context.Concesionarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (concesionario == null)
            {
                return NotFound();
            }

            return View(concesionario);
        }

        // POST: Concesionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var concesionario = await _context.Concesionarios.FindAsync(id);
            _context.Concesionarios.Remove(concesionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcesionarioExists(int id)
        {
            return _context.Concesionarios.Any(e => e.ID == id);
        }
    }
}
