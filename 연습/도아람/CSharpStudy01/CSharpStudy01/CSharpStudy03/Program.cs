using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번");
            int inch = int.Parse(Console.ReadLine());
            Console.WriteLine(inch*2.54);

            Console.WriteLine("2번");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine(kg*2.20462262);

            //원의 둘레와 넓이 구하기
            Console.WriteLine("3번");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine(2*3.14*r); //둘레
            Console.WriteLine(3.14*r*r); //넓이

            Console.WriteLine("4번");
            int num1 = int.Parse(Console.ReadLine());
            string num2 = Console.ReadLine();
            int mynum2 = int.Parse(num2);

            Console.WriteLine(num1 * (num2[2]-'0'));
            Console.WriteLine(num1 * (num2[1]-'0'));
            Console.WriteLine(num1 * (num2[0]-'0'));
            Console.WriteLine(num1 * mynum2);

            Console.WriteLine("두 번째 풀이방식");
            Console.WriteLine(num1*(mynum2%10));
            Console.WriteLine(num1*((mynum2/10)%10));
            Console.WriteLine(num1*(mynum2/100));
            Console.WriteLine(num1*mynum2);

        }
    }
}
