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
            if(false)
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

            #region 2번 문제
            /*
             * 2. 대문자A~Z, 소문자 a~z까지 반복문을
            이용해서 출력하세요.
             */
            for (char c = 'A'; c<='z'; c++)
            {
                if (c > 'Z' && c < 'a')// [, \, ] ^ _ 등...
                    continue;
                //continue 쓰고 싶지 않다면
                //continue부분 지우고
                //아래 조건문 하나 추가하면 됨
                //if ( ! (c > 'Z' && c < 'a') ) //논리 부정
                    Console.Write(c);
            }
            #endregion


            #region 3,4,5번
            Console.WriteLine();
            Console.WriteLine("출력할 별의 높이 입력하기");
            int floor = int.Parse(Console.ReadLine());

            /*
                 3. 다음 삼각형을 출력하시오.
                입력 : 3
                *
                **
                ***
                4. 다음 역삼각형을 출력하시오.
                입력 : 3
                  *
                 **
                ***
                5. 삼각형 모양의 피라미드 출력하세요.
                ex) 입력 : 3
                  *
                 ***
                *****
            */

            Console.WriteLine("3번 정답");
            for(int i = 0; i < floor; i++)
            {
                for(int j = 0;j<=i;j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("4번 정답");
            for(int i = 0; i<floor; i++)
            {
                for(int j = floor-i-1; j>0; j--)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }


            #endregion

        }
    }
}
