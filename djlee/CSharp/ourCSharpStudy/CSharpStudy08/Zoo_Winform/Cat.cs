using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Winform
{
    public class Cat : Animal
    {
        public string eyeColor { get; set; } 
        public void meow()
        {
            Console.WriteLine("야옹!");
        }
    }
}
