using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    internal class Program
    {
        public static void X(int i = 0)
        {
            Console.WriteLine("Merhaba");
            if(i < 5)
            {
                X(++i);
            }
                
            Console.WriteLine("Dünya");
        }
        
        public static int PlusMultiplesOfFive(int start, int finish)
        {
            if (start % 5 == 0)
                return start + PlusMultiplesOfFive(++start, finish);
            if (start < finish) 
                return PlusMultiplesOfFive(++start, finish);
            return 0;
        }

        public static int SubarrayWithGivenSum(int[] A, int N, int S, int i = 0)
        {
            if (SubarrayWithGivenSum(A, N, S, ++i) == S)
                return A[i] + A[i + 1];

            if (i < N)
            {
                return A[i];
                i++;
            }
            return 0;
        }

        public static void findPath(int[,] puzzle, int[] coordinates, ArrayList stayingOne)
        { 
            //Yukarı bak
            if (coordinates[0] > 0 && puzzle[coordinates[0] - 1, coordinates[1]] == 1)
            {
                int[] tempCoordinates = { coordinates[0] - 1, coordinates[1] };
                
            }

            int[,] result = new int[puzzle.GetLength(0), puzzle.GetLength(1)];

            
        }
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3 };
            int N = 3;
            int S = 3;
            Console.WriteLine(SubarrayWithGivenSum(A, N, S));








            //X();
            //Console.Write(PlusMultiplesOfFive(10,20));

            //int[,] puzzle =
            //{
            //    { 1, 1, 1, 1, 1, 1, 1, 7, 5 },
            //    { 1, 2, 4, 9, 7, 4, 1, 6, 5 },
            //    { 1, 1, 1, 4, 5, 4, 1, 1, 1 },
            //    { 7, 8, 1, 9, 7, 4, 9, 2, 5 },
            //    { 2, 0, 1, 1, 1, 1, 1, 1, 5 },
            //    { 8, 3, 7, 9, 7, 4, 9, 1, 5 },
            //    { 0, 1, 1, 1, 1, 1, 9, 1, 1 },
            //    { 2, 1, 6, 9, 7, 1, 9, 5, 1 },
            //    { 7, 1, 7, 1, 1, 1, 9, 1, 1 },
            //    { 5, 1, 7, 1, 5, 4, 9, 1, 5 },
            //    { 1, 1, 7, 1, 1, 1, 1, 1, 5 }, // starting coordinates --> 10, 0
            //};

            //Console.WriteLine(PlusMultiplesOfFive(10, 20));



            Console.ReadLine();
        }
    }
}
