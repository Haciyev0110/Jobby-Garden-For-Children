using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobbyGarden.Models;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Http;
using JobbyGarden.Extino;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace JobbyGarden.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClassroommsController : Controller
    {
        private readonly JobbyContext _context;
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Librarry", "Class");

        public ClassroommsController(JobbyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var jobbyContext = _context.Classroomms.Include(c => c.Agee).Include(c => c.Category).Include(c => c.Teacher);
            return View(await jobbyContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classroomm = await _context.Classroomms
                .Include(c => c.Agee)
                .Include(c => c.Category)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classroomm == null)
            {
                return NotFound();
            }

            return View(classroomm);
        }

       
        public IActionResult Create()
        {
            ViewData["AgeeId"] = new SelectList(_context.Ages, "Id", "Miniage", "Maxage");
            ViewData["CategoryId"] = new SelectList(_context.Categoryies, "Id", "Name");
            ViewData["TeacherId"] = new SelectList(_context.Teacherrs, "Id", "Fullname");
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "Id,Name,Price,Description,Size,Openhourse,Closehours,Startime,TeacherId,AgeeId,CategoryId")] Classroomm classroomm,IFormFile Iamgename)
        {
            if (ModelState.IsValid)
            {
                if (Iamgename != null)
                {
                    if (Extension.CheckImg(Iamgename, Extension.MAxfileSize))
                    {
                        try
                        {
                            classroomm.Iamgename = Extension.SaveImg(Iamgename, path);
                        }
                        catch
                        {

                            return View(classroomm);
                        }
                    }
                    else
                    {

                        return View(classroomm);
                    }
                   }
                else
                {
                    return RedirectToAction("Create","Classroomms");
                }

               

                _context.Add(classroomm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgeeId"] = new SelectList(_context.Ages, "Id", "Id", classroomm.AgeeId);
            ViewData["CategoryId"] = new SelectList(_context.Categoryies, "Id", "Name", classroomm.CategoryId);
            ViewData["TeacherId"] = new SelectList(_context.Teacherrs, "Id", "Fullname", classroomm.TeacherId);
            return View(classroomm);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classroomm = await _context.Classroomms.FindAsync(id);
            if (classroomm == null)
            {
                return NotFound();
            }
            ViewData["AgeeId"] = new SelectList(_context.Ages, "Id", "Id", classroomm.AgeeId);
            ViewData["CategoryId"] = new SelectList(_context.Categoryies, "Id", "Name", classroomm.CategoryId);
            ViewData["TeacherId"] = new SelectList(_context.Teacherrs, "Id", "Fullname", classroomm.TeacherId);
            return View(classroomm);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Iamgename,Price,Description,Size,Openhourse,Closehours,Startime,TeacherId,AgeeId,CategoryId")] Classroomm classroomm,IFormFile Iamgename,string fileadi)
        {
            if (id != classroomm.Id)
            {
                return NotFound();
            }


            if (Iamgename != null)
            {

                if (Extension.CheckImg(Iamgename, Extension.MAxfileSize))
                {
                    try
                    {
                        classroomm.Iamgename = Extension.SaveImg(Iamgename, path);
                        Extension.Deletimg(path, fileadi);
                    }
                    catch
                    {

                        ModelState.AddModelError("Img", "Img is not correct");
                    }


                }
                else
                {
                    ModelState.AddModelError("Img", "Img is not correct");
                }
            }
            else
            {
                classroomm.Iamgename = fileadi;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classroomm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassroommExists(classroomm.Id))
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
            ViewData["AgeeId"] = new SelectList(_context.Ages, "Id", "Id", classroomm.AgeeId);
            ViewData["CategoryId"] = new SelectList(_context.Categoryies, "Id", "Name", classroomm.CategoryId);
            ViewData["TeacherId"] = new SelectList(_context.Teacherrs, "Id", "Fullname", classroomm.TeacherId);
            return View(classroomm);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classroomm = await _context.Classroomms
                .Include(c => c.Agee)
                .Include(c => c.Category)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classroomm == null)
            {
                return NotFound();
            }

            return View(classroomm);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classroomm = await _context.Classroomms.FindAsync(id);
            _context.Classroomms.Remove(classroomm);
            await _context.SaveChangesAsync();
            Extension.Deletimg(path, classroomm.Iamgename);
            return RedirectToAction(nameof(Index));
        }

        private bool ClassroommExists(int id)
        {
            return _context.Classroomms.Any(e => e.Id == id);
        }
    }
}
