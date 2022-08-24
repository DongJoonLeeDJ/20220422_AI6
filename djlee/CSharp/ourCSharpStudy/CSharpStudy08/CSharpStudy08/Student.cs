using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy08
{
    //Student는 Human을 상속받아서
    //Name과 Age 값도 가지고 있다.
    //그리고 Sleep도 할 수 있다.

    //:(콜론) = extends(자바) 
    // (참고)
    //:(콜론) = implements(자바)
    public class Student : Human
    {
        public int score;
        public Student()
        {
            count++;
        }

        public void sayHello()
        {
            countOfHello++;
        }

        public void Study(int hour)
        {
            //참고로 Human의 privacy는 
            //상속받은 클래스일지라도 접근이 안 됨

            //Human을 상속받았으므로 Born 쓸 수 있음
            Born();
            Console.WriteLine(score+"점을 받았습니다.");
            Console.WriteLine(hour+"시간 만큼 공부합니다.");
        }
    }
}
