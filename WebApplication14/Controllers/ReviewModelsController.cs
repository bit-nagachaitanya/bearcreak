using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using WebApplication14.Data;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class ReviewModelsController : Controller
    {
        private readonly WebApplication14Context _context;

        public ReviewModelsController(WebApplication14Context context)
        {
            _context = context;
        }

        public  IActionResult Review() {
            return  View();
        }
        public  IActionResult RecentReviews() {

            IEnumerable<ReviewModel> rm = _context.Review.OrderByDescending(r => r.CreatedAt).Take(5).ToList();
            //IEnumerable<ReviewModel> rm = _context.Review.ToList();
            return View(rm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReviewSubmit(ReviewModel reviewModel)
        {
            if (ModelState.IsValid)
            {
                reviewModel.Guid = Guid.NewGuid();
                reviewModel.CreatedAt= DateTime.Now;
                _context.Add(reviewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
                
            }
            return View("Error");
        }

      

        public IActionResult Success() {
            return View();
        }

    }
}
