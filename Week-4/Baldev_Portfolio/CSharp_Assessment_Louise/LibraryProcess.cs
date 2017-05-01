using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assessment_Louise
{
    class LibraryProcess
    {
        List<Book> booklist = new List<Book>();

        int numberofbooks;

        public void viewlistofbooks()
        {

            Console.WriteLine("Total List of book:" + booklist.Count);
            Console.WriteLine("**************************************");


        }


        public void deletebookfromlist()
        {
            Console.WriteLine("Enter a book name to delete or ISBN No?:");
            Console.WriteLine(".......................");

            Console.Write("Book name: ");
            string bookname = Console.ReadLine();

            //Console.Write("Author name: ");
            //string bookauthor = Console.ReadLine();

            Console.Write("Book number ISBN: ");
            int booknumber = int.Parse(Console.ReadLine());

            //Console.Write("Book price: ");
            //float bookprice = float.Parse(Console.ReadLine());
         

            foreach (Book book in booklist)
            {
                
               
            }
         


        }

        public void sortthebooklist()
        {


        }

        public void addlistofbooks()
        {
            Console.WriteLine("Enter the list of books");
            Console.WriteLine(".......................");

            Console.Write("Book name: ");
            string bookname = Console.ReadLine();

            Console.Write("Author name: ");
            string bookauthor = Console.ReadLine();

            Console.Write("Book number ISBN: ");
            int booknumber = int.Parse(Console.ReadLine());

            Console.Write("Book price: ");
            float bookprice = float.Parse(Console.ReadLine());

            Book mybook = new Book(bookname, bookauthor, booknumber, bookprice);
            booklist.Add(mybook);
            numberofbooks++;

        }
    }
}
