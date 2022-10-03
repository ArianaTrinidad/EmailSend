using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSend.Methods
{
    public class SecondSelection
    {
        public static void ChoosingEmailFormat(string mailType, int port)
        {
            Console.WriteLine("Choose a opction\n1) Send a email preload\n2) Send a email personalized");
            var firstMenu = Convert.ToInt32(Console.ReadLine());
            if (firstMenu == 1)
            {
                Console.WriteLine("How many emails are you going to send?");
                var secondMenu = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= secondMenu; i++)
                {
                   PreloadEmail.SendPreloadEmail(mailType, port);
                }
            }
            else if (firstMenu == 2)
            {
                PersonalizedEmail.SendPersonalizedMail(mailType, port);
            }
        }
    }
}
