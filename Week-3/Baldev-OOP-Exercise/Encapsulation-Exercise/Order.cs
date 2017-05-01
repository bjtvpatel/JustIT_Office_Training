using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercise
{
    public class Order
    {

        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);
        }
        

    }
}
