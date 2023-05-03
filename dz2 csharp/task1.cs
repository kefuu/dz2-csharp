using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_csharp
{
    internal class task1
    {
        public static void func_task1(string[] args)
        {
            double[] A = new double[5];
            Console.WriteLine("Enter 5 numbers for array A:");
            
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }

            double[,] B = new double[3, 4];
            Random rand = new Random();
            
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.NextDouble();
                }
            }
            
            Console.Write("Array A: ");
            foreach (double num in A)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Console.WriteLine("Array B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }


            double max = A[0];
            double min = A[0];
            double sum = A[0];
            double product = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                sum += A[i];
                product *= A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                    product *= B[i, j];
                }
            }

           
            double evenSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += A[i];
                }
            }

        
            double oddColumnSum = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j % 2 == 1)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        oddColumnSum += B[i, j];
                    }
                }
            }

            
            Console.WriteLine("Total maximum element: " + max);
            Console.WriteLine("Total minimum element: " + min);
            Console.WriteLine("Total sum of all elements: " + sum);
            Console.WriteLine("Total product of all elements: " + product);
            Console.WriteLine("Sum of even elements of array A: " + evenSum);
            Console.WriteLine("Sum of odd columns of array B: " + oddColumnSum);
        }


    }
}
