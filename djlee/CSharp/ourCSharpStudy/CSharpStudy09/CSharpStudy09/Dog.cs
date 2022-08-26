using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{
    public class Dog : Animal
    {

        public override void Sleep()
        {
            //base.Sleep(); //조상 클래스의 Sleep
            Console.WriteLine("Dog스럽게 잔다.");
        }
    }
}
