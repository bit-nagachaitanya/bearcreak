using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class BearController : Controller
    {
        [HttpGet("")]
        [HttpGet("Home")]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet("mailservice")]
        public ActionResult Mailservice()
        {
            return View();
        }

        [HttpGet("Meet_The_Pharmacist")]
        public ActionResult Meet_The_Pharmacist()
        {
            return View();
        }



        [HttpGet("Medical_Supplies")]
        public ActionResult Medical_Supplies()
        {
            return View();
        }
        [HttpGet("Rentals")]
        public ActionResult Rentals() {

            return View();
        }

        [HttpGet("Accepted_Insurance_Providers")]
        public ActionResult Accepted_Insurance_Providers() {
            return View();
        }

        [HttpGet("Convenience_store")]
        public ActionResult Convenience_store()
        {
            return View();
        }

        public ActionResult Braces()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Pharmacy() { 
        return View();
        }
        public ActionResult Blog() { 
        return View(); }


        /*[HttpGet("Appointment")]
        public ActionResult Appointment()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAppointmentForm(AppointmentModel model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        public ActionResult Blog1() {
            return View();
        }
        public ActionResult Blog2() { 
        return View();
        }

    }
}