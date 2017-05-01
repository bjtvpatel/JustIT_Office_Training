using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car:Vehical
    {
        public static int numberOfCars = 0;
        public string type;
        
        public Car():base()
        {


        }

        public Car(string make, string model, int price):base(make, model, price)
        {
            this.type = "car";
            numberOfCars++;
            Console.WriteLine("car constructor called");

        }


        public void SoldCar(Boolean status, int price)
        {
            SoldoneVehical(status, price);
            numberOfCars--;

        }




    }
}
