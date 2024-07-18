using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo.Inheritance
{
    internal class parent
    {

        public int X { get; set; }
        public void Fun1()
        {
            Console.WriteLine(value: " Func1 from parent ");
        }
        public void Fun2()
        {
            Console.WriteLine(value: $"X: {X}");


        }


        public parent(int x)
        {
            X = x;
        }

    }
}
