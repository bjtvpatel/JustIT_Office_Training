using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baldev_ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal secreatNumber = 0;

            decimal guessNumber = 0;

            int counter = 0;

            Random ran = new Random();

            secreatNumber = ran.Next(1,100);
           
            do
            {
                Console.WriteLine("Type your best guess number");
                guessNumber = decimal.Parse(Console.ReadLine());

                if (guessNumber == secreatNumber)
                {
                    Console.WriteLine("!!Match!!");
                }
                else if (guessNumber > secreatNumber)
                {
                    Console.WriteLine("Number {0} is greater than: Secreat Number", guessNumber);
                }
                else
                {
                    Console.WriteLine("Number {0} is less than : Secreat Number ", guessNumber);

                }
                counter++;
               
            } while (counter <= 3);

        }
    }
}
