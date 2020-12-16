using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = int.Parse(Console.ReadLine());
            double[,] arr = new double[n, m];
            Random rnd = new Random();
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }
            MyMatrix matrixxx = new MyMatrix(arr);
            Console.WriteLine("The created array:");
            Console.WriteLine(matrixxx);
            Console.WriteLine("");
            Console.WriteLine("The created array:");
            Console.ReadKey();
        }
    }
}
