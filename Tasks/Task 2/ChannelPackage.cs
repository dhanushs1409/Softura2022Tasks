using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChannelPackage
    {
        public static void Main()
        {   //belongs to C#Task2
            Console.WriteLine("Welcome! Here are the packages available for you:");
            a:
            Console.WriteLine("\nPackage A:\n");
            Console.WriteLine("South Special; Children's Club; Movies");
            Console.WriteLine("\nPackage B:\n");
            Console.WriteLine("News; Sports; Movies; Regional-2");
            Console.WriteLine("\nPackage C:\n");
            Console.WriteLine("Discovery, History, National");
            char ch = '\0';
            Console.WriteLine("Please select the package you prefer (press R to show again) : ");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'R')
                goto a;
            switch (ch)
            {
                case 'A': Console.WriteLine("The rate of this package is Rs. 250");
                    break;
                case 'B': Console.WriteLine("The rate of this package is Rs. 450");
                    break;
                case 'C': Console.WriteLine("The rate of this package is Rs. 350");
                    break;
                default: Console.WriteLine("The letter entered is not listed. Please try again.");
                    break;

            }
        }
    }
}
