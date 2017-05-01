using System;
using Encapsulation_Exercise;
using Inheritance;
using Polymorphism;
using Baldev_OOP_Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace OOP_Test.cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //meal and order class tests
            Meal m = new Meal("pasta",10.00m,5.0m);
                       
            Order o = new Order();
            o.takeOrder(m);

            Meal.cookMeal(m, 0);


            //Bank accounts tests

            BankAccount b = new BankAccount(100);

            SavingsAccount s = new SavingsAccount(100, 0.5m);

            decimal balance = s.Withdraw(10);
            Assert.IsTrue(balance == ((decimal) (100 - 10 - 1.50)));
            

            
            
            
            
            //polymorphism tests 










            

        }
    }
}
