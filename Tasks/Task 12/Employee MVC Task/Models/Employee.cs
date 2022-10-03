namespace EmployeeTask.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public char Gender { get; set; }
        public Employee GetEmployee() //return a single employee
        {
            Employee emp1 = new Employee()
            {
                EmpID = 101,
                FName = "Ajay",
                LName = "Devgan",
                Gender = 'M'
            };
            return emp1;
        }
        public static List<Employee> GetAllEmployee() //returns list
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){ EmpID=101, FName="Ajay", LName="Devgan", Gender='M'},
                new Employee(){ EmpID=102, FName="Shruti", LName="Iyer", Gender='F'},
                new Employee(){ EmpID=103, FName="Akshara", LName="Modi", Gender='F'},
                new Employee(){ EmpID=104, FName="Anirudh", LName="Ashwin", Gender='M'},
                new Employee(){ EmpID=105, FName="Narendra", LName="Khan", Gender='M'},
                new Employee(){ EmpID=106, FName="Priya", LName="Sharma", Gender='F'}
            };
            return empList;
        }
    }
}
