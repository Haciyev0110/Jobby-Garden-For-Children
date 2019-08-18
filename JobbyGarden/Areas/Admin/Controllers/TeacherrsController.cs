using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobbyGarden.Models;
using Microsoft.AspNetCore.Http;
using JobbyGarden.Extino;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace JobbyGarden.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeacherrsController : Controller
    {
        private readonly JobbyContext _context;
        private readonly IHostingEnvironment _env;
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Librarry", "Teacher");

        public TeacherrsController(JobbyContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: Admin/Teacherrs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teacherrs.ToListAsync());
        }

        // GET: Admin/Teacherrs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherr = await _context.Teacherrs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherr == null)
            {
                return NotFound();
            }

            return View(teacherr);
        }

        // GET: Admin/Teacherrs/Create
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fullname,Images,Minidescription,Special,Experience,Phone,Email,Sliderdesc,Images,TitleDesc")] Teacherr teacherr,IFormFile Images)
        {

            
            if (ModelState.IsValid)
            {
                if (Extension.CheckImg(Images, Extension.MAxfileSize))
                {
                    try
                    {
                        teacherr.Images = Extension.SaveImg(Images, path);
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
                _context.Add(teacherr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
            }

        // GET: Admin/Teacherrs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherr = await _context.Teacherrs.FindAsync(id);
            if (teacherr == null)
            {
                return NotFound();
            }
            return View(teacherr);
        }

        // POST: Admin/Teacherrs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fullname,Images,Minidescription,Special,Experience,Phone,Email,Sliderdesc,TitleDesc")] Teacherr teacherr,IFormFile Images,string fileadi)
        {
            if (id != teacherr.Id)
            {
                return RedirectToAction("Index","Teachrrs");
            }

            if (Images != null) {

                if (Extension.CheckImg(Images, Extension.MAxfileSize))
                {
                    try
                    {
                        teacherr.Images = Extension.SaveImg(Images, path);
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
                teacherr.Images = fileadi;
            }

            if (ModelState.IsValid)
            {



                try
                {
                    _context.Update(teacherr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherrExists(teacherr.Id))
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
            return View(teacherr);
        }

        // GET: Admin/Teacherrs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Teacherrs");
                ;
            }

            var teacherr = await _context.Teacherrs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherr == null)
            {
                return NotFound();
            }

            return View(teacherr);
        }

        // POST: Admin/Teacherrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
         

            var teacherr = await _context.Teacherrs.FindAsync(id);
            _context.Teacherrs.Remove(teacherr);
            await _context.SaveChangesAsync();
            Extension.Deletimg(path, teacherr.Images);
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherrExists(int id)
        {
            return _context.Teacherrs.Any(e => e.Id == id);
        }
    }
}
