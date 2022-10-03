using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend.Methods
{
    public class TypeConfiguration
    {
        public static string CollerctorType(int mailTyper)
        {
            string clientConnect;
            if (mailTyper == 1)
            {
                clientConnect = "smtp.gmail.com";
            }
            else if (mailTyper == 2)
            {
                clientConnect = "smtp-mail.outlook.com";
            }
            else
            {
                Console.WriteLine("We need to know how is de client connection, please search how is the client connection for <Client Type Mail>");
                Console.WriteLine("Please tipe your mail type");
                clientConnect = Console.ReadLine();
            }
            return clientConnect;
        }
    }
}
