using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the no of batches");
            int a = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[a][];

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("Enter the no of student");
                int b = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[b];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter marks for student {0}{1} : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Marks of batch {0}, student {1} is {2}", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();

        }
    }
}
