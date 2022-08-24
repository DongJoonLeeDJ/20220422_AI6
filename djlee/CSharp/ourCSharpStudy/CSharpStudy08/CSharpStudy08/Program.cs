using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.Name = "이동준";
            h.Age = 34;
            h.Sleep();

            Student s = new Student();
            s.Name = "피강효";
            s.Age = 20;
            s.Sleep();  //Name, Age, Sleep은 Human에서 상속받은 것

            s.score = 100;
            s.Study(10);

            Worker w = new Worker();
            w.Name = "이상수";
            w.Age = 30;
            w.Sleep();
            //pay 값이 정해진 전후의 Work 출력 비교
            int money = w.Work(); //이때는 w.pay가 0
            Console.WriteLine("money="+money);
            w.pay = 5000;
            money = w.Work(); //pay가 정해진 시점의 돈
            Console.WriteLine("money="+money);
        }
    }
}
