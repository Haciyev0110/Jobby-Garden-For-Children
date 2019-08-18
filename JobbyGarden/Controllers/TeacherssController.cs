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
    public class TeacherssController : Controller
    {
        private readonly JobbyContext context;
        public TeacherssController(JobbyContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult>  Index()
        {
            HomeVM bnm = new HomeVM();
            bnm.teacherrs =await context.Teacherrs.ToListAsync();

            return View(bnm);
        }

        public async Task<IActionResult> Single(int? id)
        {
            SingleVM bnm = new SingleVM();

            bnm.teacearSingle = await context.Teacherrs.FindAsync(id);

            if (id != null)
            {
                return View(bnm);
            }
            return RedirectToAction("Index","Home");
        }


        public  async Task<IActionResult> Entrolls(Entroll entroll)
        {
            if (ModelState.IsValid)
            {

                context.Add(entroll);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }


    }
}