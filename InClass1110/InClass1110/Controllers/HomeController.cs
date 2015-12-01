using InClass1110.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace InClass1110.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //GET: Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Hello()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //GET: DOM
        public ActionResult DOM()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //GET: Practice
        public ActionResult Practice()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //GET: Sent
        public ActionResult Sent()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //GET: Sent
        public ActionResult Friday()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult GetData()
        {
            
            EmailFormModel efm = new EmailFormModel();
            efm.FromName = "Steph";
            efm.FromEmail = "sgandy3@yahoo.com";
            efm.Subject="From Server";

            return Json(efm, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("sgandy3@yahoo.com"));  // replace with valid value 
                message.From = new MailAddress(model.FromEmail);  // replace with valid value
                message.Subject = model.Subject;
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
    }
}