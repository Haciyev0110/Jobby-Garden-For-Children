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
    public class SingleClasController : Controller
    {
        private readonly JobbyContext context;
        public SingleClasController(JobbyContext _context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            
            SingleVM bnm = new SingleVM();
            bnm.clasrom =await context.Classroomms.FindAsync(id);
            bnm.agess =await context.Ages.ToListAsync();
            bnm.teacherr =await context.Teacherrs.ToListAsync();
            bnm.clasr =await context.Classroomms.ToListAsync();
            if (id != null)
            {
                return View(bnm);
            }
            return RedirectToAction("Index","Home");
        }
    }
}