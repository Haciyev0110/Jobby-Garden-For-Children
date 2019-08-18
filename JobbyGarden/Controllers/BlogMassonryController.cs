using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobbyGarden.Models;
using JobbyGarden.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace JobbyGarden.Controllers
{
    public class BlogMassonryController : Controller
    {
        private readonly JobbyContext context;
        private readonly UserManager<User> _userManager;
        public BlogMassonryController(JobbyContext _context, UserManager<User> userManager)
        {
            context = _context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            BlogmassonryVM bnm = new BlogmassonryVM();
            bnm.blogs = await context.Blogs.ToListAsync();
            bnm.galery = await context.GaleryBlogs.ToListAsync();
            bnm.users = await context.Users.ToListAsync();
            bnm.comments = await context.Comments.ToListAsync();

            return View(bnm);
        }


        public async Task<IActionResult> BlogSingle(int? id)
        {
            BlogSingleVM bnm = new BlogSingleVM();

            bnm.blog = await context.Blogs.FindAsync(id);
            bnm.users = await context.Users.ToListAsync();
            bnm.comments = new Comments();
            bnm.comajx = await context.Comments.ToListAsync();
            bnm.blogCategories = await context.BlogCategories.ToListAsync();
            bnm.galeryBlogs = await context.GaleryBlogs.ToListAsync();
            bnm.bloglist = await context.Blogs.Take(3).OrderByDescending(m => m.Id).ToListAsync();
            if (context.GaleryBlogs.Count() > 2 || context.GaleryBlogs.Count() > 3 || context.GaleryBlogs.Count() > 4)
            {
                bnm.galery2Image = await context.GaleryBlogs.Skip(1).Take(2).ToListAsync();
                bnm.galery3Image = await context.GaleryBlogs.Skip(3).Take(1).ToListAsync();
                bnm.galery4Image = await context.GaleryBlogs.Skip(4).Take(1).ToListAsync();
            }
            else
            {
                bnm.galery2Image = await context.GaleryBlogs.ToListAsync();
                bnm.galery3Image = await context.GaleryBlogs.ToListAsync();
                bnm.galery4Image = await context.GaleryBlogs.ToListAsync();

            }

            if (id != null)
            {
                return View(bnm);
            }
            return RedirectToAction("Index", "Home");
        }




        //[Authorize]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CommentsAsync(Comments comment, int postId)
        //{

        //    if (ModelState.IsValid)
        //    {

        //        var user = await _userManager.GetUserAsync(User);
        //        string userId = user.Id;

        //        comment.BlogId = postId;
        //        comment.UserId = userId;
        //        comment.Date = DateTime.UtcNow;
        //        context.Add(comment);
        //        await context.SaveChangesAsync();
        //    }

        //    //CommentAjaxVM bnm = new CommentAjaxVM();
        //    BlogSingleVM bnm = new BlogSingleVM();
            
        
        //    return PartialView("~/Views/BlogMassonry/_PArtialcomment.cshtml", await context.Comments.Where(m=>m.BlogId==postId).ToListAsync());



        //}
    }
}