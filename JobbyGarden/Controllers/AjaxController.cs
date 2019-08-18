using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobbyGarden.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace JobbyGarden.Controllers
{
    public class AjaxController : Controller
    {
        private readonly JobbyContext context;
        private readonly UserManager<User> _userManager;
        public AjaxController(JobbyContext _context,UserManager<User> userManager)
        {
            context = _context;
            _userManager = userManager;

        }

        [HttpPost]
        public async Task<IActionResult> CommentLis(string description, int? postId)
        {
           
            try
            {
                var user = await _userManager.GetUserAsync(User);
                if (User == null || User.Identity == null || !User.Identity.IsAuthenticated)
                {
                    return Json(0);
                }
                string userId = user.Id;

                Comments comment = new Comments();
                comment.BlogId = postId.Value;
                comment.UserId = userId;
                comment.Date = DateTime.UtcNow;
                comment.Descripton = description;
                context.Add(comment);
                await context.SaveChangesAsync();
                return PartialView("_PArtialcomment", comment);
            }
            catch (Exception)
            {
                return RedirectToAction();
            }

        }
    }
}