using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_booklist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> booklist = new List<string>();

            //add books
            Console.WriteLine("Enter how many of your favorite books want to add");

            int range = int.Parse(Console.ReadLine());


            for (int i =0; i<range; i++)
            {
                Console.WriteLine("Enter your book name:" );
                string book = Console.ReadLine();
                booklist.Add(book);
                //Console.WriteLine(booklist[i]);

            }

            //print a list of books
            foreach (string book in booklist)
            {
                Console.WriteLine(book);

            }


            //delete the book
           

            string ans;
            do {
                Console.WriteLine("Do you want to delete any book?");
                ans  = Console.ReadLine().ToLower();

                if (ans == "yes")
                {
                    Console.WriteLine("Enter a book name to delete:");
                    ans = Console.ReadLine();
                    booklist.Remove(ans);

               }
                              
            } while (ans != "no");


            //sort the booklist
            Console.WriteLine("Do you want to sort booklist?");

            ans = Console.ReadLine().ToLower();

            if (ans == "yes")
            {
                booklist.Sort();
                foreach(string book in booklist)
                {
                    Console.WriteLine(book);

                }
                                
            }

            Console.WriteLine("Restart the program to add, delete or sort the books");

            Console.ReadLine();


        }
    }
}
