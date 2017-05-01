using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;
            //add some meals data
            Meal steak = new Meal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal("pumpkinRisotto", 10.00M, 1.00M);
            Order order1 = new Order();
            order1.takeOrder(steak);
            balance = Meal.cookMeal(steak, balance);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            balance = Meal.cookMeal(pumpkinRisotto, balance);
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);

            Console.ReadLine();
        }
    }
}
