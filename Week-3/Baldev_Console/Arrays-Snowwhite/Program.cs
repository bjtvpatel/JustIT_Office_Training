using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "happy", "doc", "sleepy", "cozy", "grumpy", "angry" };


            for(int i=0; i<animals.Length; i++)
            {
                Console.WriteLine("Your food is ready: {0}", animals[i]);

            }

            foreach(string animal in animals)
            {
                Console.WriteLine(animal + " drink is ready for you");
            }

            Console.ReadLine();
        }
    }
}
