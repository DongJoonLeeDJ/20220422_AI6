using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //s.score = -1;
            //이에 대한 예외처리를 밖에서 해줘야 함

            //그래서 score값을 private으로 둔 뒤
            //클래스에서 예외처리하는 방법을 생각한 것
            //그리고 해당 클래스의 밖에서는 호출하고 싶지 않은
            //속성들도 있으니 접근을 막으려고 만든 것이 private


            Car c = new Car();
            Car c2 = new Car();

            c.carNumber = 9484;
            c2.carNumber = 2123;

            //c와 c2는 서로 다른 자동차
            //carNumber를 똑같게 만들 순 있는 데, 그래도
            //저장된 메모리 위치가 달라서 서로 다른 변수이다.
            //완전히 똑같게 만들 순 있다.

            Dog d = new Dog();
            d.age = 17;
            d.name = "니니"; //age, name은 Dog.cs에서 옴
            d.beonho = "2004";
            d.code = "maltiz"; //beonho, code는 Dog2.cs에서 옴

            Dog d2 = new Dog();
            d2.age = 1;
            d2.name = "꼬꼬";
            d2.beonho = "1997";
            d2.code = "chiwawa";


            Dog.species = "반려견";

            //인스턴스 변수
            //d와 d2에 들어가있는 값이 다를 수 있다.
            //d의 age와 d2의 age가 다르듯이 말이다.

            //클래스 변수
            //모든 클래스가 다 같은 값을 가짐
            //즉 여기선 Dog의 species 값을 모두
            //공유한다. 공통된 값이다.


            //여러 개의 숫자를 저장하는 List
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(5);
            numbers.Add(7);

            //여러 개의 Dog를 저장하는 List
            List<Dog> dogs = new List<Dog>();
            dogs.Add(d);
            dogs.Add(d2);
            dogs.Add(new Dog());
            dogs[2].age = 20;
            dogs[2].name = "부스";
            dogs[2].beonho = "1989";
            dogs[2].code = "mix";



            //1. 숫자만 저장하는 리스트에 값 추가하기
            List<int> mynumbers = new List<int>();
            mynumbers.Add(10);
            mynumbers.Add(5);
            mynumbers.Add(7);
            //cw tab tab
            Console.WriteLine("숫자 하나 입력해요.");
            int num = int.Parse(Console.ReadLine());
            mynumbers.Add(num);
            foreach (var item in mynumbers)
            {
                Console.WriteLine(item); //mynumbers에 
                //있는 것들 모두 출력
            }

            List<Dog> mydogs = new List<Dog>();
            Dog md = new Dog();
            md.age = 5;
            md.name = "멍멍이";
            md.beonho = "01";
            md.code = "m01";
            mydogs.Add(md);

            mydogs.Add(new Dog() {age=10,name="뽀삐",
                beonho="02",code="b02" });

            //2. 개 추가하기
            Console.WriteLine("개 이름?");
            string name = Console.ReadLine();
            Console.WriteLine("개 나이?");
            int dog_age = int.Parse(Console.ReadLine());
            Console.WriteLine("개 번호?");
            string dognum = Console.ReadLine();
            Console.WriteLine("개의 코드?");
            string dog_code = Console.ReadLine();

            Dog temp = new Dog();
            temp.name = name;
            temp.age = dog_age;
            temp.beonho = dognum;
            temp.code = dog_code;
            mydogs.Add(temp);

            //3. 입력한 숫자 삭제하기
            Console.WriteLine("삭제하고 싶은 숫자 입력해");
            int n = int.Parse(Console.ReadLine());
            mynumbers.Remove(n);

            //4. 입력한 나이의 개 삭제하기
            Console.WriteLine("삭제 하고 싶은 나이?");
            n = int.Parse(Console.ReadLine());

            //RemoveAt 이용
            //보통 뭔가를 삭제할 땐 역for문쓴다.
            for(int i = mydogs.Count-1; i>0; i--)
            {
                if (mydogs[i].age==n)
                {
                    mydogs.RemoveAt(i);
                }
            }
            Console.WriteLine("또 다른 나이 입력");
            n = int.Parse(Console.ReadLine());
            //Remove 이용하기
            for (int i = mydogs.Count - 1; i > 0; i--)
            {
                if (mydogs[i].age == n)
                {
                    Dog t = mydogs[i];
                    mydogs.Remove(t);
                }
            }



        }
    }
}
