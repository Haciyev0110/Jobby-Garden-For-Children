using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobbyGarden.Models;
using JobbyGarden.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace JobbyGarden.Controllers
{

    public class HomeController : Controller
    {
        private readonly JobbyContext _context;

        public HomeController(JobbyContext context)
        {
            _context = context;
        }
                
        public async Task<IActionResult>  Index()
        {
            HomeVM bnm = new HomeVM();
            bnm.classroms =await  _context.Classroomms.Take(4).ToListAsync();
            bnm.TeacherFirst = await _context.Teacherrs.FirstAsync();
            bnm.blogs = await _context.Blogs.OrderByDescending(m => m.Date).Take(3).ToListAsync();
            bnm.comments = await _context.Comments.ToListAsync();
            bnm.users = await _context.Users.ToListAsync();
            bnm.galeryBlogs = await _context.GaleryBlogs.ToListAsync();
            if (_context.Teacherrs.Count() > 4)
            {
                bnm.teacherrs = await _context.Teacherrs.Skip(1).Take(4).ToListAsync();

            }
            else
            {
                bnm.teacherrs =await _context.Teacherrs.ToListAsync();
            }
            bnm.ages =await _context.Ages.ToListAsync();
            return View(bnm);
        }
    }
}