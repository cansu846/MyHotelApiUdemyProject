using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController:Controller
    {
        public IActionResult Index()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); 
            }

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressForm = new MailboxAddress("HotelierAdmin","cansukocaoglu55@gmail.com");
            mimeMessage.From.Add(mailboxAddressForm);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User",model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);       

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody(); 

            mimeMessage.Subject = model.Subject;    

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com",587,false);
            client.Authenticate("cansukocaoglu55@gmail.com", "taoa ibap ppao xdym\r\n");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return RedirectToAction("Index");
        }
    }
}
