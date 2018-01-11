using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
      
    class Program
    {
        static void Main(string[] args)
        {
            object o = null;
            try
            {
                int? i = (int?)o;
                int i2 = i ?? 0;
                Console.WriteLine(i2);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            

        }

        

    }
}
