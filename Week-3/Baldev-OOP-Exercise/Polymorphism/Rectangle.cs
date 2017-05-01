using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Rectangle:Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("This is Rectangle");

        }
    }
}
