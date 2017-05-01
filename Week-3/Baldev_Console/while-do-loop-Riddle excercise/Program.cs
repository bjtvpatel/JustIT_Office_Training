using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_loop_Riddle_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            string riddles1 = "What is brown and sticky?";
            string riddles2 = "What loses its head in the morning and gets it back at night?";

            string riddles1Ans = "stick";
            string riddles11Ans = "chocolate";

            string riddles2Ans = "pillow";
            string riddles22Ans = "bed";

            string ans1 = "";
            string ans2 = "";
                    
            
            while (counter<4)
            {
                Console.WriteLine(riddles1);
                ans1 = Console.ReadLine();
                switch (ans1)
                {
                    case "stick":
                    case "chocolate":
                        Console.WriteLine("You were correct:");
                        break;

                    default:
                        Console.WriteLine("Please try again:");
                        break;
                }

                counter++;        

            }
            counter = 0;

            Console.WriteLine(riddles2);

            do
            {
                
                ans2 = Console.ReadLine();
                switch (ans2)
                {
                    case "pillow":
                    case "bed":
                        Console.WriteLine("You were correct:");
                        break;

                    default:
                        Console.WriteLine("Please try again:");
                        break;
                }

                counter++;

            } while (counter < 4);

            Console.ReadLine();
                       

        }
    }
}
