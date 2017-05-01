using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculate calc = new Calculate();

            
                calc.addnumber();

                Console.Write("Would you like to add a number to the list?(y/n):");
                string reply = Console.ReadLine().ToLower();

                
            } while ();

      



            switch (response)
            {
                case "a":

                    calc.average();
                    break;

                case "d":
                    calc.display();
                    break;

                case "s":
                    calc.sort();
                    break;

                case "x":
                    calc.exit();
                    break;

                default:
                    break;

            }





        }
    }
}
