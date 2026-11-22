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
    {   public string name { get; }
        public int accountNumber { get; }
        public double balance { get; private set; }
        public bank(string name, int accountNumber, double balance)
        {
            if (balance < 0)
                throw new ArgumentException("Initial balance cannot be negative.", nameof(balance));
            this.name = name;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
       
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.", nameof(amount));
            }

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
