using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuguetylandiaWeb.Data;
using JuguetylandiaWeb.Models;


namespace JuguetylandiaWeb.Controllers
{
    public class InventarioController : Controller
    {
        private readonly JuguetylandiaContext _context;

        public InventarioController(JuguetylandiaContext context)
        {
            _context = context;
        }

        // GET: Inventario
        public async Task<IActionResult> Index()
        {
            var juguetylandiaContext = _context.Juguetes.Include(j => j.Marca).Include(j => j.Tienda);
            return View(await juguetylandiaContext.ToListAsync());
        }

        // GET: Inventario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juguete = await _context.Juguetes
                .Include(j => j.Marca)
                .Include(j => j.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (juguete == null)
            {
                return NotFound();
            }
            decimal finalPrice = 0;
            decimal offerPrice = 0;
            if (juguete.Oferta != 0) {
                decimal dec = Decimal.Parse(juguete.PVP);
                offerPrice = dec - ((juguete.Oferta * dec) / 100);
                finalPrice = Math.Round(offerPrice, 2);

            }

            ViewData["finalPrice"] = finalPrice;

            return View(juguete);
        }

        // GET: Inventario/Create
        public IActionResult Create()
        {
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "ID", "Nombre");
            ViewData["TiendaId"] = new SelectList(_context.Tiendas, "ID", "Codigo");
            return View();
        }

        // POST: Inventario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Ean,Referencia,MarcaId,PVP,Oferta,Descripcion,Tipo,Edad,Cantidad,FechaRecepcion,TiendaId,FechaGarantia,InfoGarantia")] Juguete juguete)
        {
            System.Diagnostics.Debug.WriteLine(juguete.PVP);
            if (ModelState.IsValid)
            {
                _context.Add(juguete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "ID", "Nombre", juguete.MarcaId);
            ViewData["TiendaId"] = new SelectList(_context.Tiendas, "ID", "Codigo", juguete.TiendaId);
            return View(juguete);
        }

        // GET: Inventario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juguete = await _context.Juguetes.FindAsync(id);
            if (juguete == null)
            {
                return NotFound();
            }
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "ID", "Nombre", juguete.MarcaId);
            ViewData["TiendaId"] = new SelectList(_context.Tiendas, "ID", "Codigo", juguete.TiendaId);
            return View(juguete);
        }

        // POST: Inventario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Ean,Referencia,MarcaId,PVP,Oferta,Descripcion,Tipo,Edad,Cantidad,FechaRecepcion,TiendaId,FechaGarantia,InfoGarantia")] Juguete juguete)
        {
            if (id != juguete.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(juguete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JugueteExists(juguete.ID))
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
            ViewData["MarcaId"] = new SelectList(_context.Marcas, "ID", "Nombre", juguete.MarcaId);
            ViewData["TiendaId"] = new SelectList(_context.Tiendas, "ID", "Codigo", juguete.TiendaId);
            return View(juguete);
        }

        // GET: Inventario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juguete = await _context.Juguetes
                .Include(j => j.Marca)
                .Include(j => j.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (juguete == null)
            {
                return NotFound();
            }

            return View(juguete);
        }

        // POST: Inventario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var juguete = await _context.Juguetes.FindAsync(id);
            _context.Juguetes.Remove(juguete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JugueteExists(int id)
        {
            return _context.Juguetes.Any(e => e.ID == id);
        }
    }
}
