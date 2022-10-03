using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend.Methods
{
    public class PersonalizedEmail
    {
        public static void SendPersonalizedMail(string mailType, int port)
        {
            Console.WriteLine("Destination Mail");
            var destinationEmail = Console.ReadLine();

            Console.WriteLine("Subject Mail");
            var subjectEmail = Console.ReadLine();

            Console.WriteLine("Message Mail");
            var messageEmail = Console.ReadLine();

            Console.WriteLine("Display name for the Mail");
            var displayName = Console.ReadLine();

            Console.WriteLine("Source Mail");
            var surceMail = Console.ReadLine();

            Console.WriteLine("Password of Mail (if you use gmail you need the application pasword)");
            var password = Console.ReadLine();


            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress($"{displayName}", $"{surceMail}"));

            message.To.Add(MailboxAddress.Parse($"{destinationEmail}"));

            message.Subject = subjectEmail;

            message.Body = new TextPart("plain")
            {
                Text = messageEmail
            };

            SmtpClient client = new SmtpClient();
            ExceptionHandling.TryCatch(message, surceMail, password, client, mailType, port);
        }
    }
}
