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
