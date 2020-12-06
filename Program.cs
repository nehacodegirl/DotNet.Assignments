using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[3];
            for(int i=0;i<arr.Length;i++)
            {
                int EmpNo = Convert.ToInt32(Console.ReadLine());
                string EmpName =Console.ReadLine();
                decimal Basic = Convert.ToInt64(Console.ReadLine());
                short DeptNo = Convert.ToInt16(Console.ReadLine());
                arr[i] = new Employee(EmpNo,EmpName,Basic,DeptNo);
            }

            Console.WriteLine("Array of Employee");
            foreach(Employee e in arr)
            {
                e.show();
            }

            List<Employee> emplist = new List<Employee>();
            for(int i=0; i<arr.Length; i++)
            {
                emplist.Add(arr[i]);
            }



            Console.WriteLine("List of Employee");
            foreach( Employee emp in emplist)
            {

                emp.show();
            }
        }
    }


    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public decimal Basic { get; set; }

        public short DeptNo { get; set; }

        public Employee(int EmpNo=1, string EmpName="noname", decimal Basic=10000,short DeptNo=1)
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
