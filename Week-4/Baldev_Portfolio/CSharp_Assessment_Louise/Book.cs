using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assessment_Louise
{
    class Book
    {
        string title;
        string author;
        int ISBN;
        float price;
        

        public Book()
        {
            

        }
        public Book(string bookname, string bookauthor, int booknumber, float bookprice)
        {
            this.title = bookname;
            this.author = bookauthor;
            this.ISBN = booknumber;
            this.price = bookprice;
           
    

        }


       

    }
}
