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

        }
    }
}
