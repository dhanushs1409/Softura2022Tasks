using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class EmpData
    {
        public int empId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    internal class EmployeeSer
    {   //belongs to C#Task6
        public static void Main()
        {
            var emp1 = new EmpData()
            {
                empId = 666,
                Name = "Lucifer",
                Gender = "M",
                Age = 22
            };
            XmlSerializer serializer = new XmlSerializer(typeof(EmpData));
            using (StreamWriter stream = new StreamWriter("EmployeeData.xml"))
            {
                serializer.Serialize(stream, emp1);
            }
            Console.WriteLine(emp1.empId+emp1.Name,emp1.Gender,emp1.Age);
        }
    }
}