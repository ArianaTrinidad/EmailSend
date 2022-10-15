using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend.Methods
{
    public class PreloadEmail
    {
        public static void SendPreloadEmail()
        {
            Console.WriteLine("Destination Mail");
            var destinationEmail = Console.ReadLine();

            ///here put your subject
            var subjectEmail = "subject";

            ///here put your message
            var messageEmail = "you";

            MimeMessage message = new MimeMessage();

            ///change for you email and name/Bussines Name 
            message.From.Add(new MailboxAddress("Name", "email@typeemail.com"));

            message.To.Add(MailboxAddress.Parse($"{destinationEmail}"));

            message.Subject = subjectEmail;

            message.Body = new TextPart("plain")
            {
                Text = messageEmail
            };

            ///change for your email
            string emailAddress = "email@typeemail.com";

            ///here put your password
            string password = "password";

            ///change for your client port
            int port = 101;

            ///change for your smtp client
            string emailType = "smtp.client.com";

            SmtpClient client = new SmtpClient();
            ExceptionHandling.TryCatch(message, emailAddress, password, client, emailType, port);
        }
    }
}
