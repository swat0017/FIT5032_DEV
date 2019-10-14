using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Car4Hire.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public async void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "Car4Hire.com.au");
            var to = new EmailAddress(toEmail, "Email id");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var bytes = File.ReadAllBytes("C:/Users/swathy/source/repos/Car4Hire/Car4Hire/Images/download.png");
            var file = Convert.ToBase64String(bytes);
            
            msg.AddAttachment("file.png", file);
            var response = client.SendEmailAsync(msg);

            
        }
        public async void SendNewsletter(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "Car4Hire.com.au");
            var to = new EmailAddress(toEmail, "Email id");
            var plainTextContent = contents;
            //var htmlContent = C:/Users/swathy/source/repos/Car4Hire/Car4Hire/Utils/HtmlPage1.html;
            var htmlContent = "";

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            
           // msg.HtmlContent
            
            var response = client.SendEmailAsync(msg);


        }

    }
}