using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baldev_OOP_Exercise;

namespace Constructor
{
    class Program   
    {

        
        

        static void Main(string[] args)
        {


            List<Vehical> myCarList = new List<Vehical>();


            //print current stock of cars
            Console.WriteLine("Number of cars in stock:" + Vehical.noOfCars);

            //adding new stock to carlist
            string response;

            do
            {
                Console.WriteLine("Do you want to add new car details?");


                 response = Console.ReadLine().ToLower();

                if (response == "yes")
                {                  
                    AddNewCars(myCarList);

                }

            } while (response == "yes");

                       
            //print list of cars detail
            Vehical.ListAllCars(myCarList);

            //print no of stocks
            Console.WriteLine("Number of cars in stock:" + Vehical.noOfCars);

            //calculate the total value of car stock
            Vehical.CalculateValue(myCarList);

            do
            {
                Console.WriteLine("Do you want to Delete car details?");


                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    deleteCar(myCarList);

                }

            } while (response == "yes");
           
            //sold the car
            //myCar2.Sold(true, 8000);
            //myCar4.Sold(true, 10000);

            //print a no of cars in stock
            Console.WriteLine("Number of cars in stock:" + Vehical.noOfCars);

            //print list of cars detail
            Vehical.ListAllCars(myCarList);

            //calculate the total value again
            Vehical.CalculateValue(myCarList);


            Console.ReadLine();
        }

        private static void deleteCar(List<Vehical> myCarList)
        {
            Console.WriteLine("enter car make:");
            string carmake = Console.ReadLine();

            //Console.WriteLine("enter car model:");
            //string carmodel = Console.ReadLine();

            //Console.WriteLine("enter car price:");
            //int carprice = int.Parse(Console.ReadLine());

            Vehical mycar = new Vehical();

            

            
            
        }

        //method to add new car to list
        private static void AddNewCars(List<Vehical> myCarList)
        {
            
            Console.WriteLine("Enter car Make:");
            string carmake = Console.ReadLine();

            Console.WriteLine("enter car model:");
            string carmodel = Console.ReadLine();

            Console.WriteLine("enter car price:");
            int carprice = int.Parse(Console.ReadLine());

            
            Vehical mycar = new Vehical(carmake, carmodel, carprice);

            myCarList.Add(mycar);
        }
    }
}
