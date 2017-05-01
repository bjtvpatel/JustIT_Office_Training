using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure__Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[ , ] numbers = new double[5,5];

            double sum = 0;

            Console.WriteLine("Please enter your numbers until its stops");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = double.Parse(Console.ReadLine());
                    sum = sum + numbers[i, j];
                }


            }

            Console.WriteLine("You have entered 25 numbers and I will calculate average soon");

            double average = (sum / numbers.Length);

            Console.WriteLine("Average = " + average);
            Console.ReadLine();
        }
    }
}
