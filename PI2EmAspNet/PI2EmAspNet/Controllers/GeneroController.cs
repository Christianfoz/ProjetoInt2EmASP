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
    public class GeneroController : Controller
    {
        private readonly GeneroServices _gs;

        public GeneroController(GeneroServices gs) {
            _gs = gs;
        }
        
        public async Task<IActionResult> Index() {
            return View(await _gs.FindAllAsync());
        }

        // GET: Desenvolvedora/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var genero = await _gs.FindByIdAsync(id.Value);

            if (genero == null) {
                return NotFound();
            }

            return View(genero);
        }

        // GET: Desenvolvedora/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Desenvolvedora/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genero genero) {
            if (ModelState.IsValid) {
                await _gs.CreateAsync(genero);

                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Index));
        }

        // GET: Desenvolvedora/Edit/5
        /*
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desenvolvedora = await _context.Desenvolvedoras.FindAsync(id);
            if (desenvolvedora == null)
            {
                return NotFound();
            }
            return View(desenvolvedora);
        }

        // POST: Desenvolvedora/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDesenvolvedora,Ativo")] Desenvolvedora desenvolvedora)
        {
            if (id != desenvolvedora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(desenvolvedora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesenvolvedoraExists(desenvolvedora.Id))
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
            return View(desenvolvedora);
        }

        // GET: Desenvolvedora/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desenvolvedora = await _context.Desenvolvedoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desenvolvedora == null)
            {
                return NotFound();
            }

            return View(desenvolvedora);
        }

        // POST: Desenvolvedora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var desenvolvedora = await _context.Desenvolvedoras.FindAsync(id);
            _context.Desenvolvedoras.Remove(desenvolvedora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesenvolvedoraExists(int id)
        {
            return _context.Desenvolvedoras.Any(e => e.Id == id);
        }

    */
    }
}
