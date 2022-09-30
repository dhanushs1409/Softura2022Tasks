using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   //belongs to C#Task5
    public class Details
    {
        public int age { get; set; }
        public string name { get; set; }
        public Details(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public Details(Details d)
        {
            age = d.age;
            name = d.name;
        }
        public Details()
        {
            age = 50;
            name = "Default";
        }
        public void disp()
        {
            Console.WriteLine("Name : {0}\nAge : {1}\n", name, age);
        }
    }
    internal class NameAge
    {
        public static void Main()
        {
            Details details = new Details(101, "Gopalmedu");
            Details d1 = new Details(details);
            Details d2 = new Details() { age = 50, name = "Sunil" };
            details.disp();
            d1.disp();
            d2.disp();
            Console.WriteLine("Done!");
        }
    }
}
