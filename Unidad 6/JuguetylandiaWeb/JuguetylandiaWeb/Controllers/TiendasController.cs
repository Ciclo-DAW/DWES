﻿using System;
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
    public class TiendasController : Controller
    {
        private readonly JuguetylandiaContext _context;

        public TiendasController(JuguetylandiaContext context)
        {
            _context = context;
        }

        // GET: Tiendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tiendas.ToListAsync());
        }



        // GET: Tiendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tiendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Codigo,Direccion")] Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tienda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tienda);
        }

        // GET: Tiendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tienda = await _context.Tiendas.FindAsync(id);
            if (tienda == null)
            {
                return NotFound();
            }
            return View(tienda);
        }

        // POST: Tiendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Codigo,Direccion")] Tienda tienda)
        {
            if (id != tienda.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tienda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiendaExists(tienda.ID))
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
            return View(tienda);
        }

        // GET: Tiendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tienda = await _context.Tiendas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tienda == null)
            {
                return NotFound();
            }

            return View(tienda);
        }

        // POST: Tiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tienda = await _context.Tiendas.FindAsync(id);
            _context.Tiendas.Remove(tienda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiendaExists(int id)
        {
            return _context.Tiendas.Any(e => e.ID == id);
        }
    }
}
