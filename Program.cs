using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Q3
{
    class Program
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee { EmpNo = 1, EmpName = "Vikas", Basic = 12000, DeptNo = 10 });
            emplist.Add(new Employee { EmpNo = 2, EmpName = "Shree", Basic = 12380, DeptNo = 30 });
            emplist.Add(new Employee { EmpNo = 3, EmpName = "Harsh", Basic = 13000, DeptNo = 20 });

            Console.WriteLine("List of Employee");
            foreach (Employee obj in emplist)
            {
                obj.show();
            }

            Employee[] arr = new Employee[3];

            emplist.CopyTo(arr);
            Console.WriteLine("arr of Employee");

            foreach(Employee e in arr)
            {
                e.show();
            }
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public decimal Basic { get; set; }

        public short DeptNo { get; set; }

        public Employee(int EmpNo = 1, string EmpName = "noname", decimal Basic = 10000, short DeptNo = 1)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public void show()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Basic);
            Console.WriteLine(DeptNo);
        }
    }

}
