using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕");
            //문자열 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);//입력한 것 출력
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num+10);
            Console.WriteLine("안녕하세요"[0]);//첫 번째 글자인 안 출력
            Console.WriteLine("123"[0]);//글자 1 출력
            Console.WriteLine("123"[0] -'0'); // 진짜 숫자 1이 출력됨
            Console.WriteLine((int)"123"[0]);//글자 '1'은 아스키코드 49이다.


            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(2.54*num2); //cm단위

            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(2.20462262*num3); //파운드 단위

            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(2*3.14*num4); //둘레
            Console.WriteLine(3.14*num4*num4); //넓이

            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine(num5 * ("385"[2]-'0'));
            Console.WriteLine(num5 * ("385"[1]-'0'));
            Console.WriteLine(num5 * ("385"[0]-'0'));
            Console.WriteLine(num5*385);


            

            
        }
    }
}
