using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09_delegate_lambda
{
    internal class Program
    {
        //델리게이트(=대리자)
        //메소드를 또 다른 메소드의 매개변수로 쓸 수 있게 해주는 것
        delegate void MyDelegate();

        //매개변수가 있고 반환형이 있는 메소드를 
        //변수화할 수 있는 델리게이트
        delegate int YourDelegate(int x);


        //매개변수가 없고 반환형이 없는 메소드인 m을
        //a번 호출하게 해줌
        static void Test(MyDelegate m, int a)
        {
            for(int i = 0; i<a; i++)
            {
                m();
            }
        }

        //매개변수 x를 넣은 y 메소드를 a만큼 호출
        static void Test2(YourDelegate y, int x, int a)
        {
            for (int i = 0; i < a; i++)
                y(x);
        }

        static int Power(int x)
        {
            Console.WriteLine("제곱 : " + (x*x));
            return x * x;
        }

        static void Hello()
        {
            Console.WriteLine("ㅎㅇ");
        }

        static void Main(string[] args)
        {
            //Hello 3번 호출
            Test(Hello, 3);
            Test2(Power, 5, 10);

            //메소드를 그때 그때 만들기 힘드니
            //무명 델리게이트 만듦
            //Test 안에서만 쓰이는 메소드
            Test(delegate () { Console.WriteLine("안녕"); }, 10);

            //무명 델리게이트를 더 줄 인 것
            //람다
            Test(() => { Console.WriteLine("Hello"); }, 5);

            int j = 3;
            Test2((abcd) => {
                Console.WriteLine(abcd * abcd * abcd);
                return abcd * abcd * abcd; }, j, 30);


            //숫자 1,2,3,4,5가 있는 list
            List<int> input = new List<int>() { 1, 2, 3, 4, 5 };
            //linq
            //list에서 원하는 걸 가져올 떄 sql 문법써서 가져옴
            var all = from item in input select item; //숫자 다 가져옴

            
            var odd = from item in input where item%2 == 1 select item; //홀수만 가져옴
            var even = from item in input where item % 2 == 0 select item; //짝수만 가져옴
            Console.WriteLine("---");
            foreach (var item in all)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---");
            foreach (var item in odd)
            {

                Console.WriteLine(item);
            }   Console.WriteLine("---");
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
        }
    }
}
