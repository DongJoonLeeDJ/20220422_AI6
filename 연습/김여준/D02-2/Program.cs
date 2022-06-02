using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");

            String input = Console.ReadLine();
            Console.WriteLine(input);

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);

            Console.WriteLine("abcde"[0]);
            Console.WriteLine("123"[0]);
            Console.WriteLine("123"[0] - '0');

        }
    }
}
