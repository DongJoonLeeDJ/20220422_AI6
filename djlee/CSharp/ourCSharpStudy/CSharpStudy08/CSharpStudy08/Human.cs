using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy08
{
    public class Human
    {

        public static int count = 0;
        public static int countOfHello = 0;

        public void sayhiHello()
        {
            countOfHello++;
        }


        public string Name { get; set; }
        public int Age { get; set; }



        public Human()
        {
            count++;
            Console.WriteLine("인간 생성!!!");
        }

        public Human(int age)
        {
            this.Age = age;
            Console.WriteLine(age+"살 인간 생성~~~");
        }



        //Human클래스 내부에서만 접근가능함
        //다른 클래스에서는 접근이 안 됨
        private string privacy { get; set; }

        //Human을 상속한 클래스에서만 쓸 수 있다.
        protected void Born()
        {
            Console.WriteLine("응애응애");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잔다.");
            Console.WriteLine(Name+"님이 잡니다.");
            Console.WriteLine(Age+"살 답게 잡니다.");
        }
    }
}
