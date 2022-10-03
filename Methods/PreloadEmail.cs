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
        public static void SendPreloadEmail(string mailType, int port)
        {
            Console.WriteLine("Destination Mail");
            var destinationEmail = Console.ReadLine();

            //here put you subject
            var subjectEmail = "your subject";

            var messageEmail = "your message";

            MimeMessage message = new MimeMessage();

            //change for you email and name/Bussines Name 
            message.From.Add(new MailboxAddress("Denis", "denis@email.com"));

            message.To.Add(MailboxAddress.Parse($"{destinationEmail}"));

            message.Subject = subjectEmail;

            message.Body = new TextPart("plain")
            {
                Text = messageEmail
            };

            //change for you email
            string emailAddress = "denis@email.com";

            //here put your password
            string password = "your password or aplication pasword";

            SmtpClient client = new SmtpClient();
            ExceptionHandling.TryCatch(message, emailAddress, password, client, mailType, port);
        }
    }
}
