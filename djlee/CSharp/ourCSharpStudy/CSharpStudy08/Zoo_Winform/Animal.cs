using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Winform
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Sleep ()
        {
            Console.WriteLine("zZZ....");
        }
    }
}
