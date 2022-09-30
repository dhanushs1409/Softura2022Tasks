using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task4
    abstract class Calc
    {
        public abstract void Add(int num1, int num2);
        public abstract void Sub(int num1, int num2);
        public abstract void Mul(int num1, int num2);
        public abstract void Div(int num1, int num2);

    }
    class ResultCalc:Calc
    {
        int result;
        public override void Add(int num1, int num2)
        {
            result = num1 + num2;
            Console.WriteLine("Result: "+result);
        }
        public override void Sub(int num1, int num2)
        {
            result = num1 - num2;
            Console.WriteLine("Result: " + result);
        }
        public override void Mul(int num1, int num2)
        {
            result = num1 * num2;
            Console.WriteLine("Result: " + result);
        }
        public override void Div(int num1, int num2)
        {
            result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
    }
    internal class CalcAbs
    {
        public static void Main()
        {
            ResultCalc calc = new ResultCalc();
            calc.Add(210, 210);
            calc.Sub(71, 2);
            calc.Mul(23, 3);
            calc.Div(23, 2);
        }
    }
}
