using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {


            Manager m = new Manager("Pratik", 30, 20000, "Manager");
            Console.WriteLine(m.NAME);
            Console.WriteLine(m.EMPNO);
            Console.WriteLine(m.DEPTNO);
            Console.WriteLine(m.BASIC);
            Console.WriteLine(m.CalcNetSalary());
            Console.WriteLine(m.DESIGNATION);


            Manager m1 = new Manager("Rahul", 10, 20000, "Manager");
            Console.WriteLine(m1.NAME);
            Console.WriteLine(m1.EMPNO);
            Console.WriteLine(m1.DEPTNO);
            Console.WriteLine(m1.BASIC);
            Console.WriteLine(m1.CalcNetSalary());
            Console.WriteLine(m1.DESIGNATION);

            GeneralManager g = new GeneralManager("Rahul", 10, 20000, "GEManager", "yes");
            Console.WriteLine(g.NAME);
            Console.WriteLine(g.EMPNO);
            Console.WriteLine(g.DEPTNO);
            Console.WriteLine(g.BASIC);
            Console.WriteLine(g.CalcNetSalary());
            Console.WriteLine(g.DESIGNATION);
            Console.WriteLine(g.PERKS);


            CEO ceo = new CEO("master", 1, 50000);
            Console.WriteLine(ceo.NAME);
            Console.WriteLine(ceo.EMPNO);
            Console.WriteLine(ceo.CalcNetSalary());


            IDbFunctions idb1, idb2,idb3;
            idb3 = ceo;
            idb3.Insert("add comment");
            idb3.Update("update comment");
            idb3.Delete("delete comment");

            idb1 = m;
            idb1.Insert("add comment");
            idb1.Update("update comment");
            idb1.Delete("delete comment");


            idb2 = g;
            idb2.Insert("add comment");
            idb2.Update("update comment");
            idb2.Delete("delete comment");
        }
    }


    public interface IDbFunctions
        {
        void Insert(string comment);
        void Update(string comment);
        void Delete(string comment);
    }

    public abstract class Employee : IDbFunctions
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

        protected decimal Basic;

        public abstract decimal BASIC
        {
            get;
            set;
        }

        private static int no;
        public Employee(string Name, short DeptNo = 1, decimal Basic = 0)
        {
            this.Name = Name;
            no++;
            EmpNo = no;
            this.DeptNo = DeptNo;
            this.Basic = Basic;


        }
        public abstract decimal CalcNetSalary();
        public abstract void Insert(string comment);
        public abstract void Update(string comment);
        public abstract void Delete(string comment);

    }


    public class Manager : Employee , IDbFunctions
    {
        public override decimal BASIC
        {
            set { Basic = value; }
            get { return Basic; }

        }

        public Manager(string Name, short DeptNo = 1, decimal Basic = 0, string Designation = null) : base(Name, DeptNo, Basic)
        {

            this.Basic = Basic;
            this.Designation = Designation;
        }

        public override decimal CalcNetSalary()
        {
            decimal netsal = Basic + (Basic * 10 / 100);
            return netsal;
        }

        public override void Insert( string comment)
        {
            Console.WriteLine(comment+"--Manager");
        }

        public override void Update(string comment)
        {
            Console.WriteLine(comment + "--Manager");
        }

        public override void Delete(string comment)
        {
            Console.WriteLine(comment + "--Manager");
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


    public class GeneralManager : Manager , IDbFunctions
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

        public GeneralManager(string Name, short DeptNo, decimal Basic = 0, string Designation = null, string Perks = null) : base(Name, DeptNo, Basic, Designation)
        {
            this.Perks = Perks;
        }

        public override decimal CalcNetSalary()
        {
            decimal netsal = Basic + (Basic * 20 / 100);
            return netsal;
        }

        public override void Insert(string comment)
        {
            Console.WriteLine(comment + "--GManager");
        }

        public override void Update(string comment)
        {
            Console.WriteLine(comment + "--GManager");
        }

        public override void Delete(string comment)
        {
            Console.WriteLine(comment + "--GManager");
        }

    }

    public class CEO : Employee
    {

        public override decimal BASIC
        {
            set { Basic = value; }
            get { return Basic; }

        }

        public CEO(string Name, short DeptNo, decimal Basic) : base(Name, DeptNo, Basic)
        {

        }
        public sealed override decimal CalcNetSalary()
        {
            decimal netsal = Basic + (Basic * 50 / 100);
            return netsal;
        }

        public  sealed override  void Insert(string comment)
        {
            Console.WriteLine(comment + "--CEO");
        }

        public sealed override void Update(string comment)
        {
            Console.WriteLine(comment + "--CEO");
        }

        public sealed override void Delete(string comment)
        {
            Console.WriteLine(comment + "--CEO");
        }
    }
}
