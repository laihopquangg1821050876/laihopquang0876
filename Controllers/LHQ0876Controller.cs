using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Laihopquang876.Models;

namespace Laihopquang876.Controllers
{
    public class LHQ0876Controller : Controller
    {
        private readonly ApplicationContext _context;

        public LHQ0876Controller(ApplicationContext context)
        {
            _context = context;
        }

        // GET: LHQ0876
        public async Task<IActionResult> Index()
        {
            return View(await _context.LHQ0876.ToListAsync());
        }

        // GET: LHQ0876/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHQ0876 = await _context.LHQ0876
                .FirstOrDefaultAsync(m => m.LHQid == id);
            if (lHQ0876 == null)
            {
                return NotFound();
            }

            return View(lHQ0876);
        }

        // GET: LHQ0876/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LHQ0876/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LHQid,LHQName,LHQGendeR")] LHQ0876 lHQ0876)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lHQ0876);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lHQ0876);
        }

        // GET: LHQ0876/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHQ0876 = await _context.LHQ0876.FindAsync(id);
            if (lHQ0876 == null)
            {
                return NotFound();
            }
            return View(lHQ0876);
        }

        // POST: LHQ0876/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LHQid,LHQName,LHQGendeR")] LHQ0876 lHQ0876)
        {
            if (id != lHQ0876.LHQid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lHQ0876);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LHQ0876Exists(lHQ0876.LHQid))
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
            return View(lHQ0876);
        }

        // GET: LHQ0876/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lHQ0876 = await _context.LHQ0876
                .FirstOrDefaultAsync(m => m.LHQid == id);
            if (lHQ0876 == null)
            {
                return NotFound();
            }

            return View(lHQ0876);
        }

        // POST: LHQ0876/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lHQ0876 = await _context.LHQ0876.FindAsync(id);
            _context.LHQ0876.Remove(lHQ0876);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LHQ0876Exists(string id)
        {
            return _context.LHQ0876.Any(e => e.LHQid == id);
        }
    }
}
