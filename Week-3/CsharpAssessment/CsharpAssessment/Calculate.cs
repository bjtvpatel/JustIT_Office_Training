using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssessment
{
    public class Calculate
    {
        List<int> numberlist = new List<int>();
        int totalNumber;


        public void addnumber()
        {

            do
            {
                Console.Write("Would you like to add a number to the list?(y/n):");
                string reply = Console.ReadLine().ToLower();

                if (reply == "y")
                {
                    Console.Write("Please enter a number to the list?(y/n):");
                    int number = int.Parse(Console.ReadLine());

                    numberlist.Add(number);
                    totalNumber++;
                }


            } while (reply);
    



            
            

        }


    }
}


