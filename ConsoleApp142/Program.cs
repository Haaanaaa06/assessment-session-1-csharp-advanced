using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp142
{  public static class  PhoneExtensions
    {
        public static bool IsValidPhoneNumber(this string phoneNumber)
        {
            phoneNumber = phoneNumber.Replace("-", "")
              .Replace(" ", "")
              .Replace("(", "")
              .Replace(")", "");
            return phoneNumber.Length == 10;


        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string userInput = "(123) 456-7890";

                if (userInput.IsValidPhoneNumber())
                    Console.WriteLine("Valid number");
                else
                    Console.WriteLine("Invalid phone number");
            }
        }
    }
}
