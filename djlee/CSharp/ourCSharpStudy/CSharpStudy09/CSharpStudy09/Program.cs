using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{
    internal class Program
    {
        public static void testtest(int a, int b, out int x, out int y)
        {
            //그러나 x,y에 해당하는 mytest랑 mytest2는 값이 바뀜
            
            //out키워드는 반드시 대입문을 써줘야 함
            x = a;
            y = b;
            a++; //여기선 3001, 4001이 되도
            b++; //Main의 k, k2는 여전히 3000, 4000임
        }


        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //Animal : class
            //Person : 구조체


            
            //얕은 복사
            //aa라는 변수가 생기면서
            //새로운 메모리공간이 생기고
            //aa는 그 메모리의 위치를 가리킴
            Animal aa = new Animal();
            aa.Age = 10;

            //bb는 aa랑 똑같은 곳을 가리킴
            //bb가 바뀌면 aa도 같이 바뀜
            Animal bb = aa;
            
            //bb는 aa를 복사해서
            //bb의 Age만 바꿨는 데
            //aa의 Age도 같이 바뀜
            bb.Age = 20;
            Console.WriteLine(aa.Age); //20
            Console.WriteLine(bb.Age); //20


            //깊은 복사
            //구조체는 class와는 다르다.
            Person p1 = new Person();
            p1.Age = 100;
            Person p2 = p1; //값을 복사한 것
            //p2는 p1의 값만 가져옴
            //p2랑 p1은 다른 메모리이다.
            p2.Age = 50;
            Console.WriteLine(p1.Age);
            Console.WriteLine(p2.Age);



            int mytest = 100;
            int mytest2 = 200;
            int k = 3000;
            int k2= 4000;

            //ref 키워드도 out과 똑같다.
            //메소드에서 값이 바뀌면
            //호출한 부분에서도 값이 바뀜
            //out키워드는 반드시 값을 바꿔야 함(대입문)
            //ref는 그러진 않아도 됨

            testtest(k, k2, out mytest, out mytest2);
            Console.WriteLine(k); //3000
            Console.WriteLine(k2); //4000
            Console.WriteLine(mytest); //3000
            Console.WriteLine(mytest2); //4000




            Animal a = new Animal();
            Dog d = new Dog();
            Animal da = new Dog();//다형성

            a.Sleep();
            d.Sleep();
            da.Sleep();



            //Parse의 단점
            //공백이나 abc와 같은 문자는 숫자로
            //변환이 안 되고 프로그램을 종료시킴
            int num1 = int.Parse("123");
            num1++;
            Console.WriteLine(num1); //124


            //프로그램이 튕기지 않음
            //잘못된 값을 숫자로 바꾸려고 하면
            //그냥 0으로 바꿔버림


            //TryParse : 숫자 변경 성공시 true
            //실패시 false

            bool check = int.TryParse("abcd", out int num2);
            Console.WriteLine(num2) ;
            Console.WriteLine(check) ;

            //숫자 변경 성공
            check = int.TryParse("100", out num2);
            Console.WriteLine(num2);
            Console.WriteLine(check);


            //추상클래스랑 인터페이스 단독으론
            //인스턴스 못 만듦

            //Student ss = new Student();
            //IPlay p = new IPlay();


            //대신에
            //해당 클래스나 해당 인터페이스를 상속받은 것을
            //인스턴스로 만들 수 있다.
            //(다형성)
            //SWStudent는 Student를 상속받음
            Student ss = new SWStudent();
            //SWSTudent는 IPlay 인터페이스를 구현하고 있음
            IPlay p = new SWStudent();

        }
    }
}
