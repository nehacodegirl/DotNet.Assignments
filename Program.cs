using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            Employee e = new Employee("Amrita", 25000,60);
            Console.WriteLine("Employee Name : "+e.NAME);
            Console.WriteLine("Employee No : "+e.EMPNO);
            Console.WriteLine("Employee Basic Salary : "+e.BASIC);
            Console.WriteLine("Employee NetSalary : "+ e.NetSalary());
            Console.WriteLine("Employee Dept No : "+e.DEPTNO);

            Employee e2 = new Employee("Neha", 23000, 30);
            Console.WriteLine("Employee Name : " + e2.NAME);
            Console.WriteLine("Employee No : " + e2.EMPNO);
            Console.WriteLine("Employee Basic Salary : " + e2.BASIC);
            Console.WriteLine("Employee NetSalary : " + e2.NetSalary());
            Console.WriteLine("Employee Dept No : " + e2.DEPTNO);


            Employee e3 = new Employee("Shruti", 27000, 20);
            Console.WriteLine("Employee Name : " + e3.NAME);
            Console.WriteLine("Employee No : " + e3.EMPNO);
            Console.WriteLine("Employee Basic Salary : " + e3.BASIC);
            Console.WriteLine("Employee NetSalary : " + e3.NetSalary());
            Console.WriteLine("Employee Dept No : " + e3.DEPTNO);


            Console.WriteLine("Employee Name : " + e3.NAME);
            Console.WriteLine("Employee No : " + e3.EMPNO);

            Console.WriteLine("Employee Name : " + e2.NAME);
            Console.WriteLine("Employee No : " + e2.EMPNO);

            Console.WriteLine("Employee Name : " + e.NAME);
            Console.WriteLine("Employee No : " + e.EMPNO);



        }
    }

    public class Employee
    {
        private string Name;
        public string NAME
        {
            set
            {
                if (value == null)
                    Console.WriteLine("Name should not be blank");
                else
                    Name = value;
            }

            get
            {
                return Name;
            }
        }



        private  int EmpNo;

        public  int EMPNO
        {
           
            get { return EmpNo; }
        }
        
        private decimal Basic;
        public decimal BASIC
        {
            set
            {
                if (value >= 20000 && value <= 30000)
                    Basic = value;
                else
                    Console.WriteLine("invalid Salary");

            }
            get
            {
                return Basic;
            }
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

        public static int no = 0;
    public Employee(string Name=null,  decimal Basic = 0, short DeptNo = 0)
        {

            no++;
            EmpNo = no;
            NAME = Name;
            
            BASIC = Basic;
            DEPTNO = DeptNo;

        }

        public decimal NetSalary()
        {
            decimal netSalary = BASIC + (BASIC * 10 / 100);
            return netSalary;
        }

    }   
    
}
