using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<decimal, decimal, decimal, decimal> SimpleInterest = (P, N, R) =>
               
                   (P * N * R) / 100;
               

            Console.WriteLine(SimpleInterest(1000, 1, 10));





            Func<int, int, bool> IsGreater = (a, b) => a > b;
              

            Console.WriteLine(IsGreater(10, 5));




            Employee e = new Employee(20000);

            Func<Employee, decimal> GetBasic = emp => emp.Basic;



            Predicate<int> IsEven = a => a % 2 == 0;
            
            Console.WriteLine(IsEven(78));

            Predicate<Employee> Isgreaterthan10000 = emp => emp.Basic > 10000;

        }
    }

    
    public class Employee
    {
        
        public decimal Basic
        {
            get;
            set;
        }

        public Employee(decimal Basic)
        {
            this.Basic=Basic;
        }

        public Employee()
        { }

        
    }
}
