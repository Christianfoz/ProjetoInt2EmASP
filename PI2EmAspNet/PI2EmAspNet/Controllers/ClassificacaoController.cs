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
    public class ClassificacaoController : Controller
    {
        private readonly ClassificacaoServices _cs;

        public ClassificacaoController(ClassificacaoServices cs)
        {
            _cs = cs;
        }

        // GET: Classificacao
        public async Task<IActionResult> Index()
        {
            return View(await _cs.FindAllAsync());
        }

        // GET: Classificacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /* var classificacao = await _context.Classificacoes
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (classificacao == null)
             {
                 return NotFound();
             }
             */

            // return View(classificacao);
            return null;
        }

        // GET: Classificacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classificacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Classificacao classificacao)
        {
            if (ModelState.IsValid)
            {
                await _cs.CreateAsync(classificacao);
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Index));
        }

        // GET: Classificacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /* var classificacao = await _context.Classificacoes.FindAsync(id);
            if (classificacao == null)
            {
                return NotFound();
            }
            return View(classificacao);
            */
            return null;
        }

        // POST: Classificacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeClassificacao,Ativo")] Classificacao classificacao)
        {
            if (id != classificacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassificacaoExists(classificacao.Id))
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
            return View(classificacao);
        }

        // GET: Classificacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            /* if (classificacao == null)
             {
                 return NotFound();
             }

             return View(classificacao);
             */
            return null;
        }

        // POST: Classificacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            return RedirectToAction(nameof(Index));
        }

        private bool ClassificacaoExists(int id)
        {
            return true;
        }
    }
}
