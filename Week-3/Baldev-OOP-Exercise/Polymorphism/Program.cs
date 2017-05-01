using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {

        //Example of Bank Accounts 
        public static void MakeAWithdrawal(BankAccount ba, decimal amount)
        {
            ba.Withdraw(amount);
        }
                
        static void Main(string[] args)
        {

            BankAccount ba;
            SavingsAccount sa;

            Console.WriteLine("Withdrawal: MakeAWithdrawal(ba, ...)");
            ba = new BankAccount(200M);
            MakeAWithdrawal(ba, 100M);
            Console.WriteLine("Bank account balance is £{0:F2}", ba.Balance);
            Console.WriteLine();
            Console.WriteLine("Withdrawal: MakeAWithdrawal(sa, ...)");
            sa = new SavingsAccount(200M, 12);
            MakeAWithdrawal(sa, 100M);
            Console.WriteLine("Savings account balance is £{0:F2}", sa.Balance);



            /*//Exmple of Vehicle class
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Bicycle());
            vehicles.Add(new Car());
            vehicles.Add(new Truck());

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine("A {0} has {1} wheels.", v.GetType().Name, v.Wheels());
            }

            Truck truck1 = new Truck();
            Console.WriteLine("A {0} has {1} wheels.", truck1.GetType().Name, truck1.Wheels());*/

            /*//Example of Polymorphism - polygon
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());          //rectangle that has been cast as a polygon
            polygons.Add(new Triangle());           //triangle that has been cast as a polygon
            foreach (Polygon p in polygons)
            {
                p.Draw();
            }
            Triangle triangle1 = new Triangle();
            triangle1.Draw();
            */
            Console.ReadLine();
        }
    }
}
