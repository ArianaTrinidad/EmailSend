using System;

namespace EmailSend.Methods
{
    public class Selection
    {
        public static void ChoosingEmailFormat()
        {
            Console.WriteLine("Choose a opction\n1) Send a email preload\n2) Send a email personalized");
            var firstMenu = Convert.ToInt32(Console.ReadLine());
            if (firstMenu == 1)
            {
                Console.WriteLine("How many emails are you going to send?");
                var secondMenu = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= secondMenu; i++)
                {
                   PreloadEmail.SendPreloadEmail();
                }
            }
            else if (firstMenu == 2)
            {
                PersonalizedEmail.SendPersonalizedMail();
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
                ChoosingEmailFormat();
            }
        }
    }
}
