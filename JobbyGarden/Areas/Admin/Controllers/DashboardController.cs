using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobbyGarden.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("admin/dashboard/[action]")]
    [Authorize(Roles ="Admin")]
    public class  DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}