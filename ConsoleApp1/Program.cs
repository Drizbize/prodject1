using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            int b;
            int a;
            bool success = int.TryParse(s, out a);
            if (success)
            {
                
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   s ?? "<null>");
            }
            bool success2 = int.TryParse(s1, out b);
            if (success2)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   s1 ?? "<null>");
            }
            
            Console.ReadLine();
        }
    }
}
