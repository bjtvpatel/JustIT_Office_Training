using System;


namespace Test
{

    //Example of delegates
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.cashEvent += P_cashEvent;
            p.AddCash(50);
            p.AddCash(50);
            
        }

        public static void P_cashEvent()
        {
            Console.WriteLine("Person has reached to 100 doller");
        }
    }

    public class Person
    {
        public delegate void myEventhandler();

        public event myEventhandler cashEvent;
        public int cash;
        public int Cash
        {
            get { return cash; }
            set
            {
                cash = value; 
                if (cash >= 100)
                {
                    cashEvent?.Invoke();
                }
            }
        }
        public void AddCash(int amount)
        {
            Cash += amount;
            //Console.WriteLine(cash);
        }
    }

}
