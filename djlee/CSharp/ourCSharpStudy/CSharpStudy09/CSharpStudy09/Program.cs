using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog d = new Dog();
            Animal da = new Dog();//다형성

            a.Sleep();
            d.Sleep();
            da.Sleep();


        }
    }
}
