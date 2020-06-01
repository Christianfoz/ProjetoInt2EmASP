using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PI2EmAspNet.Models;
using PI2EmAspNet.Servicos;

namespace PI2EmAspNet.Controllers
{
    public class TipoUsuarioController : Controller
    {
        private readonly TipoUsuarioServices _ps;

        public TipoUsuarioController(TipoUsuarioServices ps) {
            _ps = ps;
        }


        // GET: TipoUsuarios
        public async Task<ActionResult> Index()
        {
            List<TipoUsuario> tipos = await _ps.FindAllAsync();
            return View(tipos);
        }

        // GET: TipoUsuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoUsuarios/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: TipoUsuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TipoUsuario tu)
        {
            try
            {
                 await _ps.CreateAsync(tu);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoUsuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoUsuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoUsuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoUsuarios/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}