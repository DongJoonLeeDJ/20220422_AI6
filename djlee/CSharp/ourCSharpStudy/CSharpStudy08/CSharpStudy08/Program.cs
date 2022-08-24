using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.Name = "이동준";
            h.Age = 34;
            h.Sleep();

            Student s = new Student();
            s.Name = "피강효";
            s.Age = 20;
            s.Sleep();  //Name, Age, Sleep은 Human에서 상속받은 것

            s.score = 100;
            s.Study(10);

            

        }
    }
}
