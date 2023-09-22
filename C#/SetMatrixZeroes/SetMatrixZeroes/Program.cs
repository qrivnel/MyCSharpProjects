using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMatrixZeroes
{
    internal class Program
    {
        public static int[,] setZeroes(int[,] matrix)
        {
            List<int[]> coordinates = findZeroes(matrix);

            foreach (int[] coordinate in coordinates)
            {
                //Up and down
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, coordinate[1]] = 0;
                }
                //Right and left
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[coordinate[0], i] = 0;
                }
            }

            return matrix;
        }
        public static List<int[]> findZeroes(int[,] matrix)
        {
            List<int[]> coordinates = new List<int[]>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int[] coordinate = new int[2];
                    if (matrix[i, j] == 0)
                    {
                        coordinate[0] = i;
                        coordinate[1] = j;
                        coordinates.Add(coordinate);
                    }
                }
            }

            return coordinates;
        }
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1,  2,  3,  4,  0 },
                { 6,  7,  8,  9,  10 },
                { 11, 12, 0, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 0,  22, 23, 24, 25 },
            };

            int[,] result = setZeroes(matrix);

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
