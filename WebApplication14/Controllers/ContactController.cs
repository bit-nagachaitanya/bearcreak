using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using WebApplication14.Data;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class ContactController : Controller
    {
        private readonly WebApplication14Context _context;

        public ContactController(WebApplication14Context context)
        {
            _context = context;
        }


        [HttpPost("SuccessContact")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuccessContact([Bind("Name,Email,PhoneNumber,Message")] ContactModel contactmodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(contactmodel);
                    await _context.SaveChangesAsync();
                    
                    return RedirectToAction(nameof(Success));
                }
                
                return View(contactmodel);
            }
            catch (Exception e)
            {
                
                return View("Error",e);
            }
        }

        public ActionResult Success() {
            return View();

        }

    }
}