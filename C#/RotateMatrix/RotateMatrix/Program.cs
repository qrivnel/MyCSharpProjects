using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RotateMatrix
{
    internal class Program
    {
        public static int[,] RotateMatrix(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            List<int> matrixData = new List<int>();

            foreach(int data in matrix)
                matrixData.Add(data);

            int x = 0;
            for(int column = result.GetLength(1) - 1; column >= 0; column--)
            {
                for(int row = 0; row < result.GetLength(0); row++)
                {
                    result[row, column] = matrixData[x];
                    x++;
                }
            }

            return result;

            
        }
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 0,  1,  2,  3,  4 },
                { 5,  6,  7,  8,  9 },
                { 10, 11, 12, 13, 14 },
                { 15, 16, 17, 18, 19 },
                { 20, 21, 22, 23, 24 }
            };

            int[,] matrix2 =
            { 
                { 1,  2,  3,  4,  5,  6 },
                { 7,  8,  9,  10, 11, 12 },
                { 13, 14, 15, 16, 17, 18 },
                { 19, 20, 21, 22, 23, 24 },
                { 25, 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35, 36 },
            };

            int[,] result = RotateMatrix(matrix2);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j]);
                    Console.Write(result[i, j] < 10 ? "   " : "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
