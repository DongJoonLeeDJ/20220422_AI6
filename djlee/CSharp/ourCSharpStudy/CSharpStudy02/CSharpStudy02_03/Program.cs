using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 연도를 입력하세요.");
            int year = int.Parse(Console.ReadLine());
            //12로 나눴을 때 나머지가 0인 건 원숭이
            //참고로 서기 1년은 닭띠
            int year_thee = year % 12;
            //조건문이 참이라서 수행해야 하는 코드가
            //1줄일 경우엔 중괄호 생략 가능함
            if (year_thee == 0)
                Console.WriteLine("원숭이");
            else if (year_thee == 1)
                Console.WriteLine("닭");
            else if (year_thee == 2)
                Console.WriteLine("개");
            else if (year_thee == 3) 
                Console.WriteLine("돼지");
            else if(year_thee==4)
                Console.WriteLine("쥐");
            else if(year_thee==5)
                Console.WriteLine("소");
            else if(year_thee==6)
                Console.WriteLine("호랑이(범)");
            else if(year_thee==7)
                Console.WriteLine("토끼");
            else if(year_thee==8)
                Console.WriteLine("용");
            else if(year_thee==9)
                Console.WriteLine("뱀");
            else if(year_thee==10)
                Console.WriteLine("말");
            else if(year_thee==11)
                Console.WriteLine("양");
            //굳이 else 를 꼭 적어야 하는 건 아님
            //그리고 모든 경우의 수를 다 써서 else가 필요 없음

            //올해를 받아온 것
            year = DateTime.Now.Year;
            year_thee = year % 12;
            switch (year_thee)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;
                case 4:
                    Console.WriteLine("쥐");
                    break;
                case 5:
                    Console.WriteLine("소");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;
                default:
                    break;
            }
        }
    }
}
