using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assessment_Louise
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<Book> booklist = new List<Book>();

            //Book mybook1 = new Book("c#", "Louise", 001, 50);
            //Book mybook2 = new Book("asp.net", "Baldev", 002, 45);
            //Book mybook3 = new Book("vb", "Nihal", 003, 55);
            //Book mybook4 = new Book("html-5", "Suprian", 004, 25);

            //booklist.Add(mybook1);
            //booklist.Add(mybook2);
            //booklist.Add(mybook3);
            //booklist.Add(mybook4);

            //Console.WriteLine("Total List of book:" + booklist.Count);
            //Console.WriteLine("**************************************");

            Console.Write("If you want to *** press A to add *** press D to delete **** press S for sorting *** press O");

            string response = Console.ReadLine().ToLower();

            LibraryProcess bookprocess = new LibraryProcess();

            switch (response)
            {

                case "a":
                    
                    bookprocess.addlistofbooks();
                    break;

                case "d":
                    bookprocess.deletebookfromlist();
                    break;

                case "s":
                    bookprocess.sortthebooklist();
                    break;

                case "o":
                    break;


            }
            Console.ReadLine();
        }

        
        //public static void addbooktolist()
        //{

        //    //Console.WriteLine("Enter the list of books");
        //    //Console.WriteLine(".......................");

        //    //Console.Write("Book name: ");
        //    //string bookname = Console.ReadLine();

        //    //Console.Write("Author name: ");
        //    //string bookauthor = Console.ReadLine();

        //    //Console.Write("Book number ISBN: ");
        //    //int booknumber = int.Parse(Console.ReadLine());

        //    //Console.Write("Book price: ");
        //    //float bookprice = float.Parse(Console.ReadLine());

        //    //Book mybook = new Book(bookname, bookauthor, booknumber, bookprice);

        //}




    }
}
