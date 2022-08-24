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

            Console.WriteLine("-----------------");

            Human h2 = new Human();
            h2.Age = 15;
            h2.Name = "김남우";
            Human h3 = new Human();
            h3.Age = 16;
            h3.Name = "김우기";

            Student s2 = new Student();
            s2.Name = "김세환";
            s2.Age = 30;
            s2.score = 90;
            Student s3 = new Student();
            s3.Name = "권건모";
            s3.Age = 40;
            s3.score = 80;

            Worker w2 = new Worker();
            w2.Name = "양명지";
            w2.Age = 20;
            w2.pay = 5000;

            Worker w3 = new Worker();
            w3.Name = "김여준";
            w3.Age = 25;
            w3.pay = 10000;

            List<Human> humen = new List<Human>();
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            humen.Add(h);
            humen.Add(h2);
            humen.Add(h3);

            students.Add(s);
            students.Add(s2);
            students.Add(s3);

            workers.Add(w);
            workers.Add(w2);
            workers.Add(w3);

            foreach (var item in humen)
            {
                item.Sleep();
            }
            foreach (var item in students)
            {
                item.Study(10);
                item.Sleep();
            }
            foreach(var item in workers)
            {
                int mymoney = item.Work();
                Console.WriteLine(mymoney);
                item.Sleep();
            }
            
        }
    }
}
