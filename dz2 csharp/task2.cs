using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_csharp
{
    internal class task2
    {
        public static void func_task2(string[] args)
        {
           
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 101);
                }
            }

          
            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            int min = arr[0, 0];
            int max = arr[0, 0];
            int minRow = 0;
            int minCol = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

        
            int sum = 0;
            int startRow = Math.Min(minRow, maxRow);
            int endRow = Math.Max(minRow, maxRow);
            int startCol = Math.Min(minCol, maxCol);
            int endCol = Math.Max(minCol, maxCol);
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }

         
            Console.WriteLine("Minimum element: " + min + " (row " + minRow + ", column " + minCol + ")");
            Console.WriteLine("Maximum element: " + max + " (row " + maxRow + ", column " + maxCol + ")");
            Console.WriteLine("Sum of elements between the minimum and maximum elements: " + sum);
        }
    }
}
