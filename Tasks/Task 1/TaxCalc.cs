using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task3
    class VAT
    {
        int taxPerc = 20;
        int totalAmt;
        public int calculateTax(int amt)
        {
            totalAmt = amt + (amt * taxPerc / 100);
            return totalAmt;
        }
    }
    class GST:VAT
    {
        int taxP = 12;
        int total;
        public new int calculateTax(int amt)
        {
            total = amt + (amt * taxP / 100);
            return total;
        }
    }
    internal class TaxCalc
    {
        public static void Main()
        {
            GST gst = new GST();
            int amount = 1000;
            amount = gst.calculateTax(amount);
            Console.WriteLine("Amount after GST: " + amount);
            VAT vat = new VAT();
            amount = 1000;
            amount = vat.calculateTax(amount);
            Console.WriteLine("Amount after VAT: " + amount);
        }
    }
}
