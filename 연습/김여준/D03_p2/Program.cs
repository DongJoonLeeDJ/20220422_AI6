using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] num1 = new int[5];
            int temp_int;

            Console.Write("no1 : ");
            num1[0] = int.Parse(Console.ReadLine());

            Console.Write("no2 : ");
            num1[1] = int.Parse(Console.ReadLine());

            Console.Write("no3 : ");
            num1[2] = int.Parse(Console.ReadLine());

            Console.Write("no4 : ");
            num1[3] = int.Parse(Console.ReadLine());

            Console.Write("no5 : ");
            num1[4] = int.Parse(Console.ReadLine());

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = i + 1; j < num1.Length; j++)
                {
                    if (num1[i] < num1[j])
                    {
                        temp_int = num1[i];
                        num1[i] = num1[j];
                        num1[j] = temp_int;
                    }
                }
            }
            Console.WriteLine("max : {0} / min : {1}", num1[0], num1[4]);

            //2
            for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            for (int i = 97; i < 123; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();

            //3
            Console.Write("Type : ");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //4
            Console.Write("Type : ");
            num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                for (int k = num2 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //5
            Console.Write("Type : ");
            num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                for (int k = num2 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //6
            //1
            int[] num3 = new int[7];

            Console.Write("no1 : ");
            num3[0] = int.Parse(Console.ReadLine());

            Console.Write("no2 : ");
            num3[1] = int.Parse(Console.ReadLine());

            Console.Write("no3 : ");
            num3[2] = int.Parse(Console.ReadLine());

            Console.Write("no4 : ");
            num3[3] = int.Parse(Console.ReadLine());

            Console.Write("no5 : ");
            num3[4] = int.Parse(Console.ReadLine());

            Console.Write("no6 : ");
            num3[5] = int.Parse(Console.ReadLine());

            Console.Write("no7 : ");
            num3[6] = int.Parse(Console.ReadLine());

            for (int i = 0; i < num3.Length; i++)
            {
                for (int j = i + 1; j < num3.Length; j++)
                {
                    if (num3[i] > num3[j])
                    {
                        temp_int = num3[i];
                        num3[i] = num3[j];
                        num3[j] = temp_int;
                    }
                }
            }
            foreach (var a in num3)
                Console.WriteLine(a);

            //7
            String ant_array = "1";
            int n = 1;

            while (n <= 20)
            {
                Console.WriteLine("no{0} : {1}", n, ant_array);

                char number = ant_array[0];
                String ant_array_temp = "";
                int count = 0;

                for (int i = 0; i < ant_array.Length; i++)
                {
                    if (number == ant_array[i])
                    {
                        count++;
                    }
                    else
                    {
                        ant_array_temp += "" + number + count;
                        count = 1;
                        number = ant_array[i];
                    }

                    if (i + 1 == ant_array.Length)
                    {
                        ant_array_temp += "" + number + count;
                    }
                }
                ant_array = ant_array_temp;
                n++;
            }

        }
    }
}
