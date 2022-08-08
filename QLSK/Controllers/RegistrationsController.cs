using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLSK.Database;

namespace QLSK.Controllers
{
    public class RegistrationsController : Controller
    {
        private readonly QLSKContext _context;

        public RegistrationsController(QLSKContext context)
        {
            _context = context;
        }

        // GET: Registrations
        public async Task<IActionResult> Index()
        {
              return _context.PhieuDKSK != null ? 
                          View(await _context.PhieuDKSK.ToListAsync()) :
                          Problem("Entity set 'QLSKContext.PhieuDKSK'  is null.");
        }

        // GET: Registrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PhieuDKSK == null)
            {
                return NotFound();
            }

            var registration = await _context.PhieuDKSK
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registration == null)
            {
                return NotFound();
            }

            return View(registration);
        }

        // GET: Registrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UID,EID,Status,Note")] Registration registration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registration);
        }

        // GET: Registrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PhieuDKSK == null)
            {
                return NotFound();
            }

            var registration = await _context.PhieuDKSK.FindAsync(id);
            if (registration == null)
            {
                return NotFound();
            }
            return View(registration);
        }

        // POST: Registrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UID,EID,Status,Note")] Registration registration)
        {
            if (id != registration.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrationExists(registration.ID))
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
            return View(registration);
        }

        // GET: Registrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PhieuDKSK == null)
            {
                return NotFound();
            }

            var registration = await _context.PhieuDKSK
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registration == null)
            {
                return NotFound();
            }

            return View(registration);
        }

        // POST: Registrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PhieuDKSK == null)
            {
                return Problem("Entity set 'QLSKContext.PhieuDKSK'  is null.");
            }
            var registration = await _context.PhieuDKSK.FindAsync(id);
            if (registration != null)
            {
                _context.PhieuDKSK.Remove(registration);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrationExists(int id)
        {
          return (_context.PhieuDKSK?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
