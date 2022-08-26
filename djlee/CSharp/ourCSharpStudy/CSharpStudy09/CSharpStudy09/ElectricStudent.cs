using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{
    public class ElectricStudent : Student
    {
        public override void study()
        {
            Console.WriteLine("전기배선을 만든다.");
        }
    }
}
