using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TPDojo.Utils;

namespace TPDojo.Controllers
{
    public class ArtsMartiauxController : Controller
    {
        private readonly DojoContext _context;

        public ArtsMartiauxController(DojoContext context)
        {
            _context = context;
        }

        // GET: ArtsMartiaux
        public async Task<IActionResult> Index()
        {
              return _context.ArtsMartiaux != null ? 
                          View(await _context.ArtsMartiaux.ToListAsync()) :
                          Problem("Entity set 'DojoContext.ArtsMartiaux'  is null.");
        }

        // GET: ArtsMartiaux/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArtsMartiaux == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtsMartiaux
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // GET: ArtsMartiaux/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtsMartiaux/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom")] ArtMartial artMartial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artMartial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artMartial);
        }

        // GET: ArtsMartiaux/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArtsMartiaux == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtsMartiaux.FindAsync(id);
            if (artMartial == null)
            {
                return NotFound();
            }
            return View(artMartial);
        }

        // POST: ArtsMartiaux/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom")] ArtMartial artMartial)
        {
            if (id != artMartial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artMartial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtMartialExists(artMartial.Id))
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
            return View(artMartial);
        }

        // GET: ArtsMartiaux/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArtsMartiaux == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtsMartiaux
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // POST: ArtsMartiaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArtsMartiaux == null)
            {
                return Problem("Entity set 'DojoContext.ArtsMartiaux'  is null.");
            }
            var artMartial = await _context.ArtsMartiaux.FindAsync(id);
            if (artMartial != null)
            {
                _context.ArtsMartiaux.Remove(artMartial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtMartialExists(int id)
        {
          return (_context.ArtsMartiaux?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
