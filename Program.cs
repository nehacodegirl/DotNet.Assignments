using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {


            Manager m = new Manager("Pratik",30, 20000,"Manager");
            Console.WriteLine(m.NAME);
            Console.WriteLine(m.EMPNO);
            Console.WriteLine(m.DEPTNO);
            Console.WriteLine(m.BASIC);
            Console.WriteLine(m.CalcNetSalary());
            Console.WriteLine(m.DESIGNATION);


            Manager m1= new Manager("Rahul", 10, 20000, "Manager");
            Console.WriteLine(m1.NAME);
            Console.WriteLine(m1.EMPNO);
            Console.WriteLine(m1.DEPTNO);
            Console.WriteLine(m1.BASIC);
            Console.WriteLine(m1.CalcNetSalary());
            Console.WriteLine(m1.DESIGNATION);

            GeneralManager g = new GeneralManager("Rahul", 10, 20000, "GEManager","yes");
            Console.WriteLine(g.NAME);
            Console.WriteLine(g.EMPNO);
            Console.WriteLine(g.DEPTNO);
            Console.WriteLine(g.BASIC);
            Console.WriteLine(g.CalcNetSalary());
            Console.WriteLine(g.DESIGNATION);
            Console.WriteLine(g.PERKS);


            CEO ceo = new CEO("master",1,50000);
            Console.WriteLine(ceo.NAME);
            Console.WriteLine(ceo.EMPNO);
            Console.WriteLine(ceo.CalcNetSalary());
        }
    }


    public abstract class Employee
    {

        private string Name;
        public string NAME
        {
            set
            {
                if (value != " ")
                    Name = value;
                else
                    Console.WriteLine("invalid Name");
            }

            get
            {
                return Name;
            }

        }

        private int EmpNo;
        public int EMPNO
        {
            get { return EmpNo; }
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

       public   decimal Basic;

        public abstract  decimal BASIC
        {
             get;
        }

        private static int no;
        public Employee(string Name,  short DeptNo=1 ,decimal Basic=0 )
        {
            this.Name = Name;
            no++;
            EmpNo = no;
            this.DeptNo = DeptNo;
            this.Basic = Basic;

            
        }
        public abstract decimal CalcNetSalary();
    }


    public class Manager : Employee
    {
        public override decimal BASIC 
        {
            get { return Basic; }
            
        }

        public Manager(string Name , short DeptNo=1, decimal Basic = 0, string Designation=null):base(Name, DeptNo,Basic)
        {
            
            this.Basic = Basic;
            this.Designation = Designation;
        }

        public override decimal CalcNetSalary()
        {
            decimal netsal = Basic+(Basic*10/100);
            return netsal;
        }

        private string Designation;
        public string DESIGNATION
        {
            set
            {
                if (value != " ")
                    Designation = value;
                else
                    Console.WriteLine("invalid Designation");
            }

            get
            {
                return Designation;
            }
        }
    }


    public class GeneralManager : Manager
    {

        private string Perks;
        public string PERKS
        {
            set
            {
                Perks = value;
            }

            get
            {
                return Perks;
            }
        }

        public GeneralManager(string Name, short DeptNo, decimal Basic = 0, string Designation = null, string Perks=null) : base(Name, DeptNo, Basic, Designation)
        {
            this.Perks = Perks;
        }

        public override decimal CalcNetSalary()
        {
            decimal netsal = Basic + (Basic * 20 / 100);
            return netsal;
        }

    }

    public class CEO : Employee
    {

        public override decimal BASIC
        {
            get { return Basic; }

        }

        public CEO(string Name, short DeptNo,decimal Basic) : base(Name, DeptNo,Basic)
        {
            
        }
        public  sealed override decimal CalcNetSalary()
        {
            decimal netsal = Basic + (Basic * 50 / 100);
            return netsal;
        }
    }
}
