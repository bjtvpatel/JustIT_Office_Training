using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Triangle:Polygon
    {
        //When create a NEW instance of methode it will refer to the base class method but if you override the behaviour.
        public new void Draw()
        {
            Console.WriteLine("This is Triangle");

        }
    }
}
