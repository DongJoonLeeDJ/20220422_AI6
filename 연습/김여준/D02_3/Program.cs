using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * 2.54 + "cm");

            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * 2.204622262 + "pound");

            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * 2 * 3.14);
            Console.WriteLine(num * num * 3.14);

            Console.WriteLine(" \t \t \t4\t7\t2");
            Console.WriteLine(" \t \tX\t4\t7\t2");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" \t \t2\t3\t6\t0");
            Console.WriteLine(" \t3\t7\t7\t6\t ");
            Console.WriteLine("1\t4\t1\t6\t \t ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1\t8\t1\t7\t2\t0");

        }
    }
}
