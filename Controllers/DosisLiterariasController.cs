using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContarlaParaVivir.Models;

namespace Contarla_Para_Vivir_PNT.Controllers
{
    public class DosisLiterariasController : Controller
    {
        private readonly ContarlaContext _context;

        public DosisLiterariasController(ContarlaContext context)
        {
            _context = context;
        }

        // GET: DosisLiterarias
        public async Task<IActionResult> Index()
        {
            return View(await _context.DosisLiterarias.ToListAsync());
        }

        // GET: DosisLiterarias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dosisLiteraria = await _context.DosisLiterarias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dosisLiteraria == null)
            {
                return NotFound();
            }

            return View(dosisLiteraria);
        }

        // GET: DosisLiterarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DosisLiterarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Texto,FechaPublicacion")] DosisLiteraria dosisLiteraria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dosisLiteraria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dosisLiteraria);
        }

        // GET: DosisLiterarias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dosisLiteraria = await _context.DosisLiterarias.FindAsync(id);
            if (dosisLiteraria == null)
            {
                return NotFound();
            }
            return View(dosisLiteraria);
        }

        // POST: DosisLiterarias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Texto,FechaPublicacion")] DosisLiteraria dosisLiteraria)
        {
            if (id != dosisLiteraria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dosisLiteraria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DosisLiterariaExists(dosisLiteraria.Id))
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
            return View(dosisLiteraria);
        }

        // GET: DosisLiterarias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dosisLiteraria = await _context.DosisLiterarias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dosisLiteraria == null)
            {
                return NotFound();
            }

            return View(dosisLiteraria);
        }

        // POST: DosisLiterarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dosisLiteraria = await _context.DosisLiterarias.FindAsync(id);
            if (dosisLiteraria != null)
            {
                _context.DosisLiterarias.Remove(dosisLiteraria);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DosisLiterariaExists(int id)
        {
            return _context.DosisLiterarias.Any(e => e.Id == id);
        }
    }
}
