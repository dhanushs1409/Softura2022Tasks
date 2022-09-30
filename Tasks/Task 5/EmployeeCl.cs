using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{   //belongs to C#Task5
    public class PersonalDetails
    {
        string name = " ";
        char gender = ' ';
        int yearsExp;
        public void getdata()
        {
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter your gender :");
            gender = Convert.ToChar(Console.Read());
            Console.WriteLine("Enter your experience in years :");
            yearsExp = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Gender : "+gender);
            Console.WriteLine("Years of experience : "+yearsExp);
        }
    }
    public class Employee:PersonalDetails
    {
        int empID;
        int salary;
        string dept = " ";
        public void get()
        {
            getdata();
            Console.WriteLine("Enter your employee ID :");
            empID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your salary :");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your department :");
            dept = Console.ReadLine();
        }
        public void disp()
        {
            display();
            Console.WriteLine("Employee ID : " + empID);
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Department : " + dept);
        }
        public void calcSalary()
        {
            switch(dept.ToUpper()) //using ToUpper to allow checking to be case-insensitive
            {
                case "SALES & MARKETING": salary = (salary * 120 / 100);
                    break;
                case "SALES AND MARKETING":
                    salary = (salary * 120 / 100);
                    break;
                case "PRODUCTION": salary = (salary * 110 / 100);
                    break;
                default: Console.WriteLine("Error in calculating new salary...");
                    break;
            }
        }
    }
    internal class EmployeeCl
    {
        public static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.get();
            emp2.get();
            emp1.calcSalary();  //updating salary in emp1
            emp2.calcSalary();  //updating salary in emp2
            emp1.disp();
            emp2.disp();
            Console.WriteLine();
        }
    }
}