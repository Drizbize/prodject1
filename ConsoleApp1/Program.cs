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
            int.TryParse(s, out a);
            int.TryParse(s1, out b);
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
