using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStore.Data;
using GameStore.Models;
using GameStore.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace GameStore.Controllers
{
    public class TiendasController : Controller
    {
        private readonly GameStoreContext _context;

        public TiendasController(GameStoreContext context)
        {
            _context = context;
        }

        // GET: Tiendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tienda.ToListAsync());
        }

        public async Task<IActionResult> ListAll(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tienda = await _context.Tienda
                .FirstOrDefaultAsync(m => m.ID == id);
            var juegos = await _context.Juegos.Include(j => j.Tienda).Where
                (m => m.Tienda.Nombre == tienda.Nombre).ToListAsync();

            var consolas = await _context.Consolas.Include(j => j.Tienda).Include(j => j.Marca).Where
                (m => m.Tienda.Nombre == tienda.Nombre).ToListAsync();

            var perifericos = await _context.Perifericos.Include(j => j.Tienda).Include(j => j.Marca).Where
                (m => m.Tienda.Nombre == tienda.Nombre).ToListAsync();

            TiendasViewModel myModel = new TiendasViewModel();
            if(juegos.Count > 0)
            {
                myModel.Juegos = juegos;
            }

            if (consolas.Count > 0)
            {
                myModel.Consolas = consolas;
            }

            if (perifericos.Count > 0)
            {
                myModel.Perifericos = perifericos;
            }

            if (tienda == null)
            {
                return NotFound();
            }

            return View(myModel);
        }

        // GET: Tiendas/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var tienda = await _context.Tienda
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (tienda == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tienda);
        //}

        // GET: Tiendas/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tiendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Direccion")] Tienda tienda)
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
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tienda = await _context.Tienda.FindAsync(id);
            if (tienda == null)
            {
                return NotFound();
            }
            return View(tienda);
        }

        // POST: Tiendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Direccion")] Tienda tienda)
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
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tienda = await _context.Tienda
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
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tienda = await _context.Tienda.FindAsync(id);
            _context.Tienda.Remove(tienda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiendaExists(int id)
        {
            return _context.Tienda.Any(e => e.ID == id);
        }
    }
}
