using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercise
{
    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;
        public Meal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
        }
        public static decimal cookMeal(Meal meal, decimal balance)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);
            balance = balance + meal.price;
            balance = balance - meal.cost;
            return balance;
        }
    }
}
