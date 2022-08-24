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

        public void Study(int hour)
        {
            Console.WriteLine(score+"점을 받았습니다.");
            Console.WriteLine(hour+"시간 만큼 공부합니다.");
        }
    }
}
