using System;

namespace EmailSend.Methods
{
    public class FirstSelection
    {
        public static void ChoosingEmailType()
        {
            Console.WriteLine("Choose a opction\n1) Gmail type\n2) Hotmail Type\n3) Another");
            var selectType = Convert.ToInt32(Console.ReadLine());
            var type = TypeConfiguration.CollerctorType(selectType);
            var port = PortConfiguration.CollerctorPort(selectType);
            SecondSelection.ChoosingEmailFormat(type, port);
        }
    }
}
