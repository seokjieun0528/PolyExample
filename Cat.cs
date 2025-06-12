using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Cat : Animal
    {
        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public new void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        public void Meow() { Console.WriteLine("왈왈 짓습니다."); }
    }
}
