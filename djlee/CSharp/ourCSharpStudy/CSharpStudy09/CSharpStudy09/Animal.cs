﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy09
{
    public class Animal
    {
        public int Age { get; set; }
        public virtual void Sleep()
        {
            Console.WriteLine("쿨쿨 잡니다.");
        }
    }
}