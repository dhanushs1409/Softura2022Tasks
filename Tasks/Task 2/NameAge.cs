using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task2
    internal class NameAge
    {
        public static void Main()
        {
            int age = 0;
            String name;
            Console.WriteLine("\nEnter your name :\n");
            name = Console.ReadLine();
            Console.WriteLine("\nEnter your age :\n");
            age = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(name, '\t');
            }
        }
    }
}
