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


            //다형성을 활용하면 1개의 foreach문,
            //1개의 List에 이 9개의 데이터를 모두 넣을 수 있다.

            //다형성 : 다양한 형태를 띌 가능성
            //왼쪽은 조상클래스 오른쪽은 왼쪽의 자손이어 함

            Human ex1 = new Student();
            Human ex2 = new Worker();

            //ex1, ex2는 모두 Human타입의 변수
            //그러나 오른쪽 부분이 자손 클래스
            //즉 인스턴스는 자손클래스로 만들어짐
            //그래서 자손으로 형변환이 가능함
            //ex1.Study(5);
            //오른쪽 부분이 자손이기 때문에 가능
            ((Student)ex1).Study(5);
            (ex1 as Student).Sleep();

            //영어로 치면 is 법칙이 성립
            //Student is Human
            //오른쪽꺼 is 왼쪽꺼
            //Worker is Human

            List<Human> people = new List<Human>()
            { h,h2,h3,s,s2,s3,w,w2,w3 };

            people.Add(new Human());
            people[9].Age = 10;
            people[9].Name = "여대훈";
            
            people.Add(new Student());
            people[10].Age = 40;
            people[10].Name = "이주민";
            (people[10] as Student).score = 50;

            people.Add(new Worker());
            people[11].Age = 50;
            people[11].Name = "김홍근";
            (people[11] as Worker).pay = 30;

            ex1.Name = "예시1";
            people.Add(ex1);
            ex2.Name = "예시2";
            people.Add(ex2);

            Student stu = new Student();
            stu.Name = "이유나";
            stu.Age = 24;
            stu.score = 100;
            people.Add(stu);

            foreach(var item in people)
            {
                item.Sleep();
                if (item is Student) //인스턴스를 뭘로 만들었는가?
                    (item as Student).Study(1);
                if (item is Worker)
                {
                    int m = (item as Worker).Work();
                    Console.WriteLine(m);
                }
            }

            Worker www = new Worker(100);
            www.Name = "김구";


            Console.WriteLine(Human.count);
            Console.WriteLine(Worker.count);
            Console.WriteLine(Student.count);


            h.sayhiHello();
            s.sayHello();
            w.sayHi();

            Console.WriteLine(Human.countOfHello);
            Console.WriteLine(Worker.countOfHello);
            Console.WriteLine(Student.countOfHello);


        }
    }
}
