﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Cat
    {
        public Cat()
        {
            Age = 0;
        }

        public int Age { get; set; }
        public string Color { get; set; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("왈왈 짓습니다."); }
    }
}
