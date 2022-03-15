using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using Web01.Models;

namespace Web01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult metodoEmail(ClassEmail classEmail)
        {
            email(classEmail);
            
            return View("Index");
        }

        private void email(ClassEmail classEmail)
        {
          MailMessage mail =new MailMessage();


            mail.To.Add(classEmail.email);

            mail.From= new MailAddress("ggerardab@gmail.com");
            mail.Subject=classEmail.asunto;
            mail.Body = classEmail.mensaje;


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("ggerardab@gmail.com","2Barcelona$$");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}