using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EBCalc
    {
        public static void Main()
        {   //belongs to C#Task1
            int slab1 = 200, slab2 = 150, slab3 = 150; //slab
            int r1 = 2, r2 = 3, r3 = 5, r4 = 7; //rate
            int temp1, temp2, temp3;
            int consumd = 0;
            int amt = 0;
            Console.WriteLine("Good Day!\n\nEnter the number of units:");
            consumd = Convert.ToInt32(Console.ReadLine());
            if (consumd <= 200)
            {
                amt = consumd * r1;
                Console.WriteLine("Amount to be paid for entered units is : "+amt);
            }
            else if (consumd <= 350)
            {
                temp1 = slab1 * r1;
                consumd = consumd - 200;
                amt = (consumd * r2) + temp1;
                Console.WriteLine("Amount to be paid for entered units is : "+amt);
            }
            else if (consumd <= 500)
            {
                temp1 = slab1 * r1;
                consumd = consumd - slab1;
                temp2 = slab2 * r2;
                consumd = consumd - slab2;
                amt = (consumd * r3) + temp1 + temp2;
                Console.WriteLine("Amount to be paid for entered units is : "+amt);
            }
            else if (consumd > 500)
            {
                temp1 = slab1 * r1;
                consumd = consumd - slab1;
                temp2 = slab2 * r2;
                consumd = consumd - slab2;
                temp3 = slab3 * r3;
                consumd = consumd - slab3;
                amt = (consumd * r4) + temp1 + temp2 + temp3;
                Console.WriteLine("Amount to be paid for entered units is : "+amt);
            }

        }
    }
}
