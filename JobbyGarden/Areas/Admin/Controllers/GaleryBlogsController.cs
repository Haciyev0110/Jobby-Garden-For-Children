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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace JobbyGarden.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GaleryBlogsController : Controller
    {
        private readonly JobbyContext _context;
        private readonly IHostingEnvironment _env;
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Librarry", "Blog");
        public GaleryBlogsController(JobbyContext context)
        {
            _context = context;
        }

        // GET: Admin/GaleryBlogs
        public async Task<IActionResult> Index()
        {
            var jobbyContext = _context.GaleryBlogs.Include(g => g.Blog);
            return View(await jobbyContext.ToListAsync());
        }

        // GET: Admin/GaleryBlogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeryBlog = await _context.GaleryBlogs
                .Include(g => g.Blog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeryBlog == null)
            {
                return NotFound();
            }

            return View(galeryBlog);
        }

        // GET: Admin/GaleryBlogs/Create
        public IActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Name");
            return View();
        }

        // POST: Admin/GaleryBlogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BlogId")] GaleryBlog galeryBlog, IEnumerable<IFormFile> ImageBlog)
        {
            if (ModelState.IsValid)
            {


                foreach (var item in ImageBlog)
                {

                    if (Extension.CheckImg(item, Extension.MAxfileSize))
                    {
                        try
                        {
                            galeryBlog.ImageBlog = Extension.SaveImg(item, path);
                        }
                        catch
                        {

                            return View(galeryBlog);
                        }
                    }
                    else
                    {
                        return View(galeryBlog);
                    }
                    GaleryBlog gales = new GaleryBlog
                    {
                        Id = galeryBlog.Id,
                        ImageBlog = galeryBlog.ImageBlog,
                        BlogId = galeryBlog.BlogId
                    };


                    _context.Add(gales);


                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));

            }
          
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Name", galeryBlog.BlogId);
            return View(galeryBlog);
        }

        // GET: Admin/GaleryBlogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeryBlog = await _context.GaleryBlogs.FindAsync(id);
            if (galeryBlog == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Blogdesc1", galeryBlog.BlogId);
            return View(galeryBlog);
        }

        // POST: Admin/GaleryBlogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageBlog,BlogId")] GaleryBlog galeryBlog,IFormFile ImageBlog, string fileadi)
        {
            if (id != galeryBlog.Id)
            {
                return NotFound();
            }
            if (ImageBlog != null)
            {

                if (Extension.CheckImg(ImageBlog, Extension.MAxfileSize))
                {
                    try
                    {
                        galeryBlog.ImageBlog = Extension.SaveImg(ImageBlog, path);
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
                galeryBlog.ImageBlog = fileadi;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galeryBlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaleryBlogExists(galeryBlog.Id))
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
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Blogdesc1", galeryBlog.BlogId);
            return View(galeryBlog);
        }

        // GET: Admin/GaleryBlogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeryBlog = await _context.GaleryBlogs
                .Include(g => g.Blog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeryBlog == null)
            {
                return NotFound();
            }

            return View(galeryBlog);
        }

        // POST: Admin/GaleryBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galeryBlog = await _context.GaleryBlogs.FindAsync(id);
            _context.GaleryBlogs.Remove(galeryBlog);
            Extension.Deletimg(path, galeryBlog.ImageBlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaleryBlogExists(int id)
        {
            return _context.GaleryBlogs.Any(e => e.Id == id);
        }
    }
}
