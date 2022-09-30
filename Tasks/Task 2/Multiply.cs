using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task2
    internal class Multiply
    {
        public static void Main()
        {
            Console.WriteLine("\nEnter a number to view its multiplication table : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i)); 
            }
        }
    }
}
