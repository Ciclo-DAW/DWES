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
    public class VehiculosController : Controller
    {
        private readonly ConcesionarioContext _context;

        public VehiculosController(ConcesionarioContext context)
        {
            _context = context;
        }

        // GET: Vehiculos
        public async Task<IActionResult> Index()
        {
            var concesionarioContext = _context.Vehiculos.Include(v => v.Concesionario).Include(v => v.Ubicacion);
            return View(await concesionarioContext.ToListAsync());
        }

        // GET: Vehiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos
                .Include(v => v.Concesionario)
                .Include(v => v.Ubicacion)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return View(vehiculo);
        }

        // GET: Vehiculos/Create
        public IActionResult Create()
        {
            ViewData["ConcesionarioId"] = new SelectList(_context.Concesionarios, "ID", "Nome");
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nome");
            return View();
        }

        // POST: Vehiculos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Marca,Modelo,TipoVehiculo,Combustible,Estado,Descripcion,NumBastidor,DataRecepcion,DataVenta,ConcesionarioId,UbicacionId")] Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConcesionarioId"] = new SelectList(_context.Concesionarios, "ID", "Nome", vehiculo.ConcesionarioId);
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nome", vehiculo.UbicacionId);
            return View(vehiculo);
        }

        // GET: Vehiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }
            ViewData["ConcesionarioId"] = new SelectList(_context.Concesionarios, "ID", "Nome", vehiculo.ConcesionarioId);
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nome", vehiculo.UbicacionId);
            return View(vehiculo);
        }

        // POST: Vehiculos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Marca,Modelo,TipoVehiculo,Combustible,Estado,Descripcion,NumBastidor,DataRecepcion,DataVenta,ConcesionarioId,UbicacionId")] Vehiculo vehiculo)
        {
            if (id != vehiculo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculoExists(vehiculo.ID))
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
            ViewData["ConcesionarioId"] = new SelectList(_context.Concesionarios, "ID", "Nome", vehiculo.ConcesionarioId);
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nome", vehiculo.UbicacionId);
            return View(vehiculo);
        }

        // GET: Vehiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiculo = await _context.Vehiculos
                .Include(v => v.Concesionario)
                .Include(v => v.Ubicacion)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            return View(vehiculo);
        }

        // POST: Vehiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.ID == id);
        }
    }
}
