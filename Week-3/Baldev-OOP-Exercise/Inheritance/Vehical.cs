using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehical
    {
        private string model;
        private string make;
        private int price;
        private Boolean sold;
        private string color;


        public Vehical()
        {


        }

        //constructor
        public Vehical(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
        }


        //constructor
        public Vehical(string make, string model, int price, string color)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.color = color;
        }


        //constructor
        public Vehical(string make, string model, Boolean sold)
        {
            this.make = make;
            this.model = model;
            this.sold = sold;
         
        }


        //method to add attibute
        public void addNewCar(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
        }

        public void showVehicalList()
        {

            Console.WriteLine("List of car details Make:{0}, Model:{1}, Price: £{2}, Color:{3}", make, model, price, color);

            if (sold)
            {
                Console.WriteLine("This Car has been sold");
            }
            else
            {
                Console.WriteLine("This Car is UNSOLD");

            }

            Console.WriteLine();

        }

        //print a list of all vehical
        public static void ListAllVehical(List<Vehical> myCarList)
        {
            Car mycar = new Car();
            MotorCycle myMC = new MotorCycle();


             int noOfCars = 0;
            foreach (Vehical car in myCarList)
            {
                Console.WriteLine("List of car details Make:{0}, Model:{1}, Price: £{2}, Status of car:{3}, MotorCycle?:{4}, Car?:{5}", car.make, car.model, car.price, car.sold, car.color, mycar.type);
                noOfCars++;
            }

        }

        //Vehical sold update
        public void SoldoneVehical(Boolean status, int price)
        {
            this.sold = status;
            this.price = price;


        }

        //calculate valuation of vehical stock
        public static void CalculateValue(List<Vehical> mycarlist)
        {
            int totalcarValue = 0;
            int totalValueCarSold = 0;

            foreach (Vehical car in mycarlist)
            {
                if (car.sold == false)
                {
                    totalcarValue = totalcarValue + car.price;

                }
                else
                {
                    totalValueCarSold = totalValueCarSold + car.price;

                }

            }
            Console.WriteLine("Total value of cars:{0}", totalcarValue);
            Console.WriteLine("Total value of cars SOLD:{0}", totalValueCarSold);
        }

       



    }


}

