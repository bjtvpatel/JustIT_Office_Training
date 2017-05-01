using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Exercise
{
    class Program
    {

        //class PresidentialCandidate
        //{


        //}
            
            
        static void Main(string[] args)
        {
            string selectCandidate = "";
            int counter = 0;

            string candidate1 = "George Bush";
            string candidate2 = "Hilary Clinton";
            string candidate3= "Barak Obama";

            Console.WriteLine("List of Presidential Candidate: {0} {1} {2} {3} {4} {5}", "\n", candidate1, "\n", candidate2, "\n", candidate3);

            Console.WriteLine("Enter your choice of candidate for vote either in first name, surname or full name");

            while (counter<3) { 

            selectCandidate = Console.ReadLine().ToLower();

            switch(selectCandidate)
            {
                //case "George Bush":
                //case "George":
                //case "Bush":
                case "george bush":
                case "george":
                case "bush":
                    Console.WriteLine("You have voted for {0}", candidate1);
                    break;

                //case "Hilary Clinton":
                //case "Hilary":
                //case "Clinton":
                case "hilary clinton":
                case "hilary":
                case "clinton":
                    Console.WriteLine("You have voted for {1}", candidate2);
                    break;

                //case "Barak Obama":
                //case "Barak":
                //case "Obama":
                case "barak obama":
                case "barak":
                case "obama":
                    Console.WriteLine("You have voted for {2}", candidate3);
                    break;

                default:
                        Console.Write("You entered wrong name. Please try again");
                        break;

                }
                                
                counter++;
            }



            Console.ReadLine();

        }
    }
}
