using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MotorCycle:Vehical
    {
        public static int numberOfMC = 0;

        public string type;


        public MotorCycle():base()
        {


        }

        public MotorCycle(string make, string model, int price):base(make, model, price)
        {
            
            this.type = "motorcycle";
            numberOfMC++;
            Console.WriteLine("motorcycle constructor called");

        }

        public void SoldCar(Boolean status, int price)
        {
            SoldoneVehical(status, price);
            numberOfMC--;

        }








    }
}
