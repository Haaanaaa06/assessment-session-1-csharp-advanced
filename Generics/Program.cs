using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{ using System;
    interface IPrinter
    {
        void Print();
    }
    class Report : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Report");
        }
    }
    class Invoice : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Invoice");
        }
    }

    class SimplePrinter<T> where T : IPrinter
    {
        public void PrintObject(T obj )
        {
            obj.Print();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Report report = new Report();
            Invoice invoice = new Invoice();

            SimplePrinter<Report> reportPrinter = new SimplePrinter<Report>();
            SimplePrinter<Invoice> invoicePrinter = new SimplePrinter<Invoice>();

            reportPrinter.PrintObject(report);
            invoicePrinter.PrintObject(invoice);


        }


    }
}
