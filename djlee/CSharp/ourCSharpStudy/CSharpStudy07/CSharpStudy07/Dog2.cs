using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    public partial class Dog
    {
        //생성자는 아무것도 안 적으면
        //아래와 같이 아무 것도 없는 생성자가 자동으로
        //만들어져 있다.
        public Dog() //생성자
        {

        }

        public string beonho { get; set; }
        public string code { get; set; }

        //종 이름
        //앞에 static이 붙어서 
        //모든 Dog에서 공통적으로 쓰임
        //static이 붙는 걸 클래스 변수
        //static이 안 붙는 걸 인스턴스 변수
        public static string species { get; set; }

    }
}
