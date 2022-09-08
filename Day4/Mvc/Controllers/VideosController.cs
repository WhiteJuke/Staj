using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class VideosController : Controller
    {
        private readonly VideosContext _context;

        public VideosController(VideosContext context)
        {
            _context = context;
        }

        // GET: Videos
        public async Task<IActionResult> Index()
        {
              return _context.Videostats != null ? 
                          View(await _context.Videostats.ToListAsync()) :
                          Problem("Entity set 'VideosContext.Videostats'  is null.");
        }

        // GET: Videos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Videostats == null)
            {
                return NotFound();
            }

            var videostats = await _context.Videostats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videostats == null)
            {
                return NotFound();
            }

            return View(videostats);
        }

        // GET: Videos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Videos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Link,Title,Author")] Videostats videostats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videostats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videostats);
        }

        // GET: Videos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Videostats == null)
            {
                return NotFound();
            }

            var videostats = await _context.Videostats.FindAsync(id);
            if (videostats == null)
            {
                return NotFound();
            }
            return View(videostats);
        }

        // POST: Videos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Link,Title,Author")] Videostats videostats)
        {
            if (id != videostats.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videostats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideostatsExists(videostats.Id))
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
            return View(videostats);
        }

        // GET: Videos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Videostats == null)
            {
                return NotFound();
            }

            var videostats = await _context.Videostats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videostats == null)
            {
                return NotFound();
            }

            return View(videostats);
        }

        // POST: Videos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Videostats == null)
            {
                return Problem("Entity set 'VideosContext.Videostats'  is null.");
            }
            var videostats = await _context.Videostats.FindAsync(id);
            if (videostats != null)
            {
                _context.Videostats.Remove(videostats);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideostatsExists(int id)
        {
          return (_context.Videostats?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
