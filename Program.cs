using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Q1
{
    class Program
    {
        static void Main()
        {
           
            

            Console.Write("Enter the no of Employee" );
            int l = Convert.ToInt32(Console.ReadLine());

            //Employee e;
            Employee[] arr = new Employee[l];
            
            for (int i=0; i<l;i++)
            {
                arr[i] = new Employee();
                Console.Write("enter Employee Name  : ");

              arr[i].EMPNAME = Console.ReadLine();
                Console.Write("enter Employee Dept no  : ");
               arr[i].DEPTNO= Convert.ToInt16(Console.ReadLine());
                Console.Write("enter Employee Basic Salary : ");
              arr[i].BASIC = Convert.ToInt32(Console.ReadLine());
                
                
                
            }

            Array.Sort(arr);
            foreach(Employee emp in arr)
            {
                emp.show();
            }
        
        }
    }

    public class Employee
    {
        
        
        private int EmpNo;
        public int EMPNO
        {
            get { return EmpNo; }
        }
        
        
        
        private string EmpName;


        public string EMPNAME
        {
            set { EmpName = value; }
            get { return EmpName; }
        }

        private short DeptNo;

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("invalid Dept No");
            }

            get
            {
                return DeptNo;
            }
        }


        private decimal Basic;
        public decimal BASIC
        {
            set { Basic = value; }
            get { return Basic; }
        }

        private static int eid = 0;
        public Employee(string EmpName = "noname", short DeptNo =0,decimal Basic=0)
        {
            eid++;
            EmpNo = eid;
            this.EmpName = EmpName;
            this.DeptNo = DeptNo;
            this.Basic = Basic;

        }

       public void show()
        {
            Console.WriteLine(EMPNO);
            Console.WriteLine(EMPNAME);
            Console.WriteLine(DEPTNO);
            Console.WriteLine(BASIC);
        }
    }
}
