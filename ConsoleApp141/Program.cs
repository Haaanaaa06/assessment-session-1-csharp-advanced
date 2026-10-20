using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp141 { 
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
}
 class bank
    {         public string name;
        public int accountNumber;
        public double balance;
        public bank(string name, int accountNumber, double balance)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
       
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient funds for withdrawal.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal of {amount} successful. New balance: {balance}");
            }
               
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {   bank myBank = new bank("haana", 123456, 1000.0);
            try
            {
                myBank.Withdraw(1500.0);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
