using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task3
    class BasicOps
    {
        int res;
        public void Add(int n1, int n2)
        {
            res = n1 + n2;
            Console.WriteLine("The result of the Addition is: " + res);
        }
        public void Sub(int n1, int n2)
        {
            res = n1 - n2;
            Console.WriteLine("The result of the Subtraction is: " + res);
        }
    }
    class AdvancedOps:BasicOps
    {
        int result;
        public void Multiply(int n1, int n2)
        {
            result = n1 * n2;
            Console.WriteLine("The result of the Multiplication is: "+result);
        }
        public void Divide(int n1, int n2)
        {
            result = n1 / n2;
            Console.WriteLine("The result of the Division is: " + result);
        }
    }
    internal class Arithmetic
    {
        public static void Main()
        {
            AdvancedOps ops = new AdvancedOps();
            ops.Add(46, 100);
            ops.Sub(92, 23);
            ops.Multiply(42, 10);
            ops.Divide(1332, 2);
        }
    }
}
