using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car mycar = new Car();

            List<Vehical> myVehicalList = new List<Vehical>();

            //print current stock of cars
            Console.WriteLine("Number of cars in stock:", + Car.numberOfCars);

            //adding new stock to carlist
            string response;

            do
            {
                Console.WriteLine("Do you want to add new car details?");


                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    AddNewVehical(myVehicalList);

                }

            } while (response == "yes");


            //print list of cars detail
            Vehical.ListAllVehical(myVehicalList);

            //print no of stocks
            Console.WriteLine("Number of cars in stock:");

            //calculate the total value of car stock
            Vehical.CalculateValue(myVehicalList);

            do
            {
                Console.WriteLine("Do you want to Delete car details?");


                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    deleteCar(myVehicalList);

                }

            } while (response == "yes");

           
            //print a no of cars in stock
            Console.WriteLine("Number of cars in stock:" + Car.numberOfCars);

            //print list of cars detail
            Vehical.ListAllVehical(myVehicalList);

            //calculate the total value again
            Vehical.CalculateValue(myVehicalList);


            Console.ReadLine();
        }

        private static void deleteCar(List<Vehical> myVehicalList)
        {
            Console.WriteLine("enter car make:");
            string carmake = Console.ReadLine();
                     
            
        }

        


        //method to add new car to list
        

        private static void AddNewVehical(List<Vehical> myVehicalList)
        {

            Console.WriteLine("Do you want to add car or motorcycle?");
            string responce = Console.ReadLine().ToLower();
                       
           
            Console.WriteLine("Enter Make:");
            string vmake = Console.ReadLine();

            Console.WriteLine("Enter model:");
            string vmodel = Console.ReadLine();

            Console.WriteLine("enter price:");
            int vprice = int.Parse(Console.ReadLine());

            //Car mycar = new Car(carmake, carmodel, carprice);


            switch (responce)
            {
                case "car":
                    Car mycar = new Car(vmake, vmodel, vprice);
                    myVehicalList.Add(mycar);
                    break;

                case "motorcycle":
                    MotorCycle mymotorcycle = new MotorCycle(vmake, vmodel, vprice);
                    myVehicalList.Add(mymotorcycle);
                    break;

                default:
                    Console.WriteLine("enter valid choice");
                    break;


            }
           
        }
    }

}
