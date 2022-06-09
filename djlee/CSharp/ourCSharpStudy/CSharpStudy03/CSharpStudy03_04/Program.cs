using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1번 문제
            /*
             * 1. 5개의 숫자를 입력받고
                그 중에서 최댓값과 최솟값을 출력하시오.
             */
            int[] numbers = new int[5];
            for(int i = 0; i<numbers.Length;i++)
            {
                Console.WriteLine("숫자 입력("+i+")");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            int min = max; //둘 다 가장 첫번째껄 최댓값,
            //최솟값으로 가정함

            foreach(var item in numbers)
            {
                if(item>max)
                    max = item;
                if (item < min)
                    min = item;
            }
            Console.WriteLine("최댓값:"+max);
            Console.WriteLine("최솟값:"+min);
            #endregion
        }
    }
}
