using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy08
{
    public class Worker : Human
    {
        //Name, Age, Sleep이 이미 포함되어 있다.

        public Worker()
        {
            count++;
        }

        public void sayHi()
        {
            countOfHello++;
        }
        
        //조상클래스에 있는 생성자중에서
        //매개변수가 있는 생성자를 명시적으로 호출
        public Worker(int a) : base(a)
       {
            Console.WriteLine("나이:"+a);
       }

        public int pay { get; set; }
        public int Work()
        {
            if(pay==0)
                Console.WriteLine("열정페이 ㅠㅠ");
            else
                Console.WriteLine(pay+"만큼 일을 합니다.");

            return pay * 30;
        }
    }
}
