using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobbyGarden.Models;
using Microsoft.AspNetCore.Authorization;

namespace JobbyGarden.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AgesController : Controller
    {
        private readonly JobbyContext _context;

        public AgesController(JobbyContext context)
        {
            _context = context;
        }

        // GET: Admin/Ages1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ages.ToListAsync());
        }

        // GET: Admin/Ages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var age = await _context.Ages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (age == null)
            {
                return NotFound();
            }

            return View(age);
        }

        // GET: Admin/Ages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Ages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Miniage,Maxage")] Age age)
        {
            if (ModelState.IsValid)
            {
                _context.Add(age);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(age);
        }

        // GET: Admin/Ages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var age = await _context.Ages.FindAsync(id);
            if (age == null)
            {
                return NotFound();
            }
            return View(age);
        }

        // POST: Admin/Ages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Miniage,Maxage")] Age age)
        {
            if (id != age.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(age);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgeExists(age.Id))
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
            return View(age);
        }

        // GET: Admin/Ages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var age = await _context.Ages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (age == null)
            {
                return NotFound();
            }

            return View(age);
        }

        // POST: Admin/Ages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var age = await _context.Ages.FindAsync(id);
            _context.Ages.Remove(age);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgeExists(int id)
        {
            return _context.Ages.Any(e => e.Id == id);
        }
    }
}
