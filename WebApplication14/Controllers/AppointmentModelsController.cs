using Microsoft.AspNetCore.Mvc;
using WebApplication14.Data;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class AppointmentModelsController : Controller
    {
        private readonly WebApplication14Context _context;

        public AppointmentModelsController(WebApplication14Context context)
        {
            _context = context;
        }

        public IActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitAppointmentForm(
            [Bind("First_name,Last_name,Phonenumber,Services")] AppointmentModel appointmentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointmentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            return View("Error");
        }

        public ActionResult Success() { 
        return View();  
        }

    }
} 
