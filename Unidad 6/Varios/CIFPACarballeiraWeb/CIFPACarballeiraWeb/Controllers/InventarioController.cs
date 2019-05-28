using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIFPACarballeiraWeb.Data;
using CIFPACarballeiraWeb.Models;
using Microsoft.AspNetCore.Authorization;

namespace CIFPACarballeiraWeb.Controllers
{
    [Authorize]
    public class InventarioController : Controller
    {
        private readonly CIFPACarballeiraContext _context;

        public InventarioController(CIFPACarballeiraContext context)
        {
            _context = context;
        }

        // GET: Inventario
        public async Task<IActionResult> Index()
        {
            var cIFPACarballeiraContext = _context.Materiales.Include(m => m.Departamento).Include(m => m.Ubicacion);
            return View(await cIFPACarballeiraContext.ToListAsync());
        }

        // GET: Inventario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Materiales
                .Include(m => m.Departamento)
                .Include(m => m.Ubicacion)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (material == null)
            {
                return NotFound();
            }

            return View(material);
        }

        // GET: Inventario/Create
        public IActionResult Create()
        {
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "ID", "Nombre");
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nombre");
            return View();
        }

        // POST: Inventario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,NumSerie,TipoMaterial,Descripcion,Cantidad,Proveedor,FechaRecepcion,FechaGarantia,FechaRetirada,InfoGarantia,TipoUso,Estado,RowVersion,DepartamentoId,UbicacionId")] Material material)
        {
            if (ModelState.IsValid)
            {
                _context.Add(material);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "ID", "Nombre", material.DepartamentoId);
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nombre", material.UbicacionId);
            return View(material);
        }

        // GET: Inventario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Materiales.FindAsync(id);
            if (material == null)
            {
                return NotFound();
            }
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "ID", "Nombre", material.DepartamentoId);
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nombre", material.UbicacionId);
            return View(material);
        }

        // POST: Inventario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,NumSerie,TipoMaterial,Descripcion,Cantidad,Proveedor,FechaRecepcion,FechaGarantia,FechaRetirada,InfoGarantia,TipoUso,Estado,RowVersion,DepartamentoId,UbicacionId")] Material material)
        {
            if (id != material.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(material);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialExists(material.ID))
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
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "ID", "Nombre", material.DepartamentoId);
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "ID", "Nombre", material.UbicacionId);
            return View(material);
        }

        // GET: Inventario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Materiales
                .Include(m => m.Departamento)
                .Include(m => m.Ubicacion)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (material == null)
            {
                return NotFound();
            }

            return View(material);
        }

        // POST: Inventario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var material = await _context.Materiales.FindAsync(id);
            _context.Materiales.Remove(material);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaterialExists(int id)
        {
            return _context.Materiales.Any(e => e.ID == id);
        }
    }
}
