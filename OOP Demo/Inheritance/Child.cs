using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo.Inheritance
{
    internal class Child: parent
    {


        public int Y { get; set; }
        // keyword Base 
        //Accessing an overridden function member from the subclass
        //Calling a base-class constructor (see the next section)


        // constroctor chaining 
        public Child(int x, int y) : base(x)
        {
            Y = y;
        }
    }
}
