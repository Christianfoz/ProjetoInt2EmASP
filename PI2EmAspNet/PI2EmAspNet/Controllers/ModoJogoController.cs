using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using PI2EmAspNet.Servicos;

namespace PI2EmAspNet.Controllers
{
    public class ModoJogoController : Controller
    {
        private readonly ModoJogoServices _ms;

        public ModoJogoController(ModoJogoServices ms)
        {
            _ms = ms;
        }

        // GET: ModoJogo
        public async Task<IActionResult> Index()
        {
            return View(await _ms.FindAllAsync());
        }

        // GET: ModoJogo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modoJogo = await _ms.FindByIdAsync(id.Value);
            if (modoJogo == null)
            {
                return NotFound();
            }

            return View(modoJogo);
        }

        // GET: ModoJogo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ModoJogo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ModoJogo modoJogo)
        {
            if (ModelState.IsValid)
            {
                await _ms.CreateAsync(modoJogo);
                return RedirectToAction(nameof(Index));
            }
            return View(modoJogo);
        }

        // GET: ModoJogo/Edit/5
        /*
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modoJogo = await _context.ModoJogos.FindAsync(id);
            if (modoJogo == null)
            {
                return NotFound();
            }
            return View(modoJogo);
        }

        // POST: ModoJogo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeModo,Ativo")] ModoJogo modoJogo)
        {
            if (id != modoJogo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modoJogo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModoJogoExists(modoJogo.Id))
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
            return View(modoJogo);
        }

        // GET: ModoJogo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modoJogo = await _context.ModoJogos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modoJogo == null)
            {
                return NotFound();
            }

            return View(modoJogo);
        }

        // POST: ModoJogo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modoJogo = await _context.ModoJogos.FindAsync(id);
            _context.ModoJogos.Remove(modoJogo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModoJogoExists(int id)
        {
            return _context.ModoJogos.Any(e => e.Id == id);
        }
        */
    }
}
