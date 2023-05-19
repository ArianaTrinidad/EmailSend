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
            var subjectEmail = "Búsqueda Laboral";

            ///here put your message
            var messageEmail = "Buenos días\n\n" +
                        "Mi nombre es Ariana soy desarrolladora NetCore con C#, participo de un proyecto donde realizamos una api rest utilizando " +
                        "SQLServer, Git " +
                        "y metodologías ágiles.\n\nActualmente estoy en búsqueda de una posición Trainee +/ Jr, en caso de que tengan alguna oferta " +
                        "que se adecue me " +
                        "gustaría participar del proceso de selección.\n\nLes adjunto mi CV\n\n" +
                        "https://www.linkedin.com/in/ariana-quirino/overlay/1635503840977/single-media-viewer/" +
                        "\n\nDesde ya gracias por su tiempo, saludos";
                
            MimeMessage message = new MimeMessage();

            ///change for you email and name/Bussines Name 
            message.From.Add(new MailboxAddress("Ariana Quirino", "quirino.ariana1@gmail.com"));

            message.To.Add(MailboxAddress.Parse($"{destinationEmail}"));

            message.Subject = subjectEmail;

            message.Body = new TextPart("plain")
            {
                Text = messageEmail
            };

            ///change for your email
            string emailAddress = "quirino.ariana1@gmail.com";

            ///here put your password
            string password = "agtkhcpyqzqnxusq";

            ///change for your client port
            int port = 465;

            ///change for your smtp client
            string emailType = "smtp.gmail.com";

            SmtpClient client = new SmtpClient();
            ExceptionHandling.TryCatch(message, emailAddress, password, client, emailType, port);
        }
    }
}
