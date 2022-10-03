using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend.Methods
{
    public class PortConfiguration
    {
        public static int CollerctorPort(int mailTyper)
        {
            int port;
            if (mailTyper == 1)
            {
                port = 465;
            }
            else if (mailTyper == 2)
            {
                port = 587;
            }
            else
            {
                Console.WriteLine("Please tipe your default port");
                port = Convert.ToInt32(Console.ReadLine());
            }
            return port;
        }
    }
}
