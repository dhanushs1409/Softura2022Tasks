using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task2
    internal class StudentArr
    {
        public static void Main()
        {
            int total = 0;
            double perc;
            int[] arr = new int[5];
            Console.WriteLine("Enter the marks of your 5 subjects : ");
            for (int i = 0; i < 5; i++)
            {   Console.WriteLine("Marks obtained: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                total = total + arr[i];
            }
            perc = Convert.ToDouble(total) / 5;
            Console.WriteLine("Your total marks obtained is : " + total);
            Console.WriteLine("Your average marks are : " + perc);
        }
    }
}
