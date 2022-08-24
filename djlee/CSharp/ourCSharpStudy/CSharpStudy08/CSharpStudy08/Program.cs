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
        }
    }
}
