using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   //belongs to C#Task4
    abstract class Member
    {
        public string medal;
        int daysInResort;
        int dinners;
        public abstract void display();
        public abstract void set(string Medal);
    }
    class Membership : Member
    {
        public int daysInResort = 0; //3s 5g 7p
        public int dinners = 0; //0s 2g 5p
        public override void set(string Medal)
        {
            medal = Medal;
            if (medal == null)
            {
                Console.WriteLine("Please try again");
            }
            if (Medal.ToLower() == "silver")
            {
                daysInResort = 3;
                dinners = 0;
            }
            if (Medal.ToLower() == "gold")
            {
                daysInResort = 5;
                dinners = 2;
            }
            if (Medal.ToLower() == "platinum")
            {
                daysInResort = 7;
                dinners = 5;
            }
        }
        public override void display()
        {
            if (medal == null)
            {
                Console.WriteLine("Medal not awarded.");
            }
            if (medal.ToLower() == "silver")
            {
                Console.WriteLine("The medal awarded is Silver");
            }
            if (medal.ToLower() == "gold")
            {
                Console.WriteLine("The medal awarded is Gold");
            }
            if (medal.ToLower() == "platinum")
            {
                Console.WriteLine("The medal awarded is Platinum");
            }
        }

        internal class MembershipPackage
        {
            public static void Main()
            {
                Membership obj = new Membership();
                Console.WriteLine("Welcome!");
                obj.set("Gold");
                obj.display();
            }
        }
    }
}
