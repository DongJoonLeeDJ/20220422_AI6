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


        }
    }
}
