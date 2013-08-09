using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View(new ContactUsViewModel());
        }

        public ActionResult Contact(ContactUsViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",new ContactUsViewModel());
            }

            var fromAddress = new MailAddress("lupusteam.projects@gmail.com", viewModel.fullName);
            var toAddress = new MailAddress("lupusteam.projects@gmail.com");
            const string fromPassword = "skullsett";
            const string subject = "Subject";
            var stringBuilder = new StringBuilder();
            string body = stringBuilder.Append("Nombre Completo: ").AppendLine(viewModel.fullName)
                                       .Append("Telefono: ").AppendLine(viewModel.phone)
                                       .Append("E-Mail: ").AppendLine(viewModel.mail)
                                       .Append("Empresa: ").AppendLine(viewModel.enterprise)
                                       .Append("Mensaje: ").AppendLine(viewModel.message).ToString();

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            ModelState.Clear();
            return View("Index");
        }
    }
}
