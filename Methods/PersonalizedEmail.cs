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
        public static void SendPersonalizedMail()
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
            var sourceMail = Console.ReadLine();

            Console.WriteLine("Password of Mail (if you use gmail you need the application pasword)");
            var password = HidePassword();

            int port;
            string emailType;

            TypeSelector(sourceMail, out port, out emailType);

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress($"{displayName}", $"{sourceMail}"));

            message.To.Add(MailboxAddress.Parse($"{destinationEmail}"));

            message.Subject = subjectEmail;

            message.Body = new TextPart("plain")
            {
                Text = messageEmail
            };

            SmtpClient client = new SmtpClient();
            ExceptionHandling.TryCatch(message, sourceMail, password, client, emailType, port);
        }

        private static void TypeSelector(string sourceMail, out int port, out string emailType)
        {
            if (sourceMail.Contains("@gmail"))
            {
                port = 465;
                emailType = "smtp.gmail.com";
            }
            else if (sourceMail.Contains("@hotmail"))
            {
                port = 587;
                emailType = "smtp-mail.outlook.com";
            }
            else
            {
                port = default;
                emailType = default;
                Console.WriteLine("The email type is invalid, try again");
                SendPersonalizedMail();
            }
        }
        private static string HidePassword()
        {
            List<string> FisrtPass = new List<string>();
            while (true)
            {
                var keyboard = Console.ReadKey(true);
                if (keyboard.Key == ConsoleKey.Enter)
                {
                    break;
                }
                FisrtPass.Add(Convert.ToString(keyboard.KeyChar));
                Console.Write("*");
            }
            string data = "";

            for (int i = 0; i < FisrtPass.Count(); i++)
            {
                data += FisrtPass[i];
            }
            return data;
        }
    }
}
