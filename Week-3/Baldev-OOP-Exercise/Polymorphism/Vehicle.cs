using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Vehicle
    {
        public virtual int Wheels()
        {
            return 0;

        }
    }


    public class Bicycle: Vehicle
    {
        public override int Wheels()
        {
            return 2;
        }

    }


    public class Car : Vehicle
    {
        public new int Wheels()
        {
            return 18;

        }

    }

    public class Truck : Vehicle
    {
        public override int Wheels()
        {
            return 6;

        }

    }

}
