using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_11_Message_Printer_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter the message: C# is fun I am going to code C# tomorrow ");
            var message = Console.ReadLine();
            Console.WriteLine(message);

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            Console.WriteLine(messageArray);

            foreach (char c in message)
            {
                Console.WriteLine(c);
            }
            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }
                
        }
    }
}
