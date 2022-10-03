using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend.Methods
{
    public class ExceptionHandling
    {
        public static void TryCatch(MimeMessage message, string emailAddress, string password, SmtpClient client, string mailType, int port)
        {
            try
            {
                client.Connect($"{mailType}", port, true);
                client.Authenticate(emailAddress, password);
                client.Send(message);

                Console.WriteLine("Email sent");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Email wasn't send beacuse {ex.Message}");
                Console.ReadLine();
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();

            }
        }
    }
}
