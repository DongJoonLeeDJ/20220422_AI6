﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Console
{
    public class Dog : Animal
    {
        public string hairColor { get; set; }
        
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }
}
