using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy08
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잔다.");
            Console.WriteLine(Name+"님이 잡니다.");
            Console.WriteLine(Age+"살 답게 잡니다.");
        }
    }
}
