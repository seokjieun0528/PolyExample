using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    internal class Animal
    {
        private void Private() { }
        protected void Protected() { }
        public void Public() { }

        public int Age { get; set; }

        public void TestA()
        {
            Private();
            Protected();
            Public();
        }

        public Animal()
        {
            Age = 0;
        }

        public virtual void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public virtual void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }
}
