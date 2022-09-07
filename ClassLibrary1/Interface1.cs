using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface Ibank
    {
        void PrintBalance(double amount);
        void CalculateInterest(double amount);
    }

    public class Saving : Ibank
    {
        public void PrintBalance(double amount)
        {
            Console.WriteLine("The available balance in your savings account is " + amount);
        }
        public void CalculateInterest(double amount)
        {
            amount = amount + (amount * 0.004);
            Console.WriteLine("The available balance in your savings account after adding interest is " + amount);
        }
    }

    public class Current : Ibank
    {
        public void PrintBalance(double amount)
        {
            Console.WriteLine("The available balance in your current account is " + amount);
        }
        public void CalculateInterest(double amount)
        {
            amount = amount + (amount * 0.002);
            Console.WriteLine("The available balance in your Current account after adding interest is " + amount);
        }
      
        
    }

}