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
    public class ClasessController : Controller
    {
        private readonly JobbyContext context;
        public ClasessController(JobbyContext _context)
        {
            context = _context;
        }
        public async Task<IActionResult>  Index()
        {
            HomeVM bnm = new HomeVM();

            bnm.classroms =await context.Classroomms.ToListAsync();
            bnm.ages =await context.Ages.ToListAsync();
            bnm.categ =await context.Categoryies.ToListAsync();
            bnm.teacherrs =await context.Teacherrs.Take(4).ToListAsync();


            return View(bnm);
        }
    }
}