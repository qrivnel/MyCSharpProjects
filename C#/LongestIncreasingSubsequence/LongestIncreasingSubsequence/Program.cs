using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    internal class Program
    {
        public static bool LISHelperContains(int max, ArrayList maxS)
        {
            foreach(int value in maxS)
                if(value == max) 
                    return true;

            return false;
        }
        public static int LISHelper(int index, int[] arr, ArrayList maxS)
        {
            int max = 1;
            for(int i = 0; i < index; i++)
            {
                int tempMax = LISHelper(i, arr, maxS);
                if (arr[i] < arr[index])
                    if (tempMax + 1 > max)
                        max = tempMax + 1;
            }
            if(!LISHelperContains(max, maxS))
                maxS.Add(max);
            return max;
        }


        public static int result(int[] array)
        {
            ArrayList maxS = new ArrayList();
            return LISHelper(array.Length - 1, array, maxS);
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60, 80 }; //Longest increasing subsequence --> 10, 22, 33, 50, 60, 80 => 6
            int[] arr2 = { 99, 44, 55, 2, 66, 3, 4, 5 };
            int[] arr3 = { 7, 9, 11, 5, 77, 6, 19, 21, 35, 101 };
            int[] arr4 = { 1, 2, 112, 70, 71, 68, 1, 2, 3 };
            int[] arr5 = { 1, 5, 3, 9, 6, 7 };

            Console.WriteLine(result(arr));

            Console.ReadLine();
        }
    }
}
