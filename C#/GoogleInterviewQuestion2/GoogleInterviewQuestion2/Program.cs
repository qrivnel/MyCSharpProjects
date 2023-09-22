using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleInterviewQuestion2
{
    internal class Program
    {
        public static string Result(List<int> numbers, int k)
        {
            foreach(int number in numbers)
            {
                foreach(int numberr in numbers)
                {
                    if(number + numberr == k && number != numberr)
                    {
                        return number + " " + numberr;
                    }

                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 15, 5, 7 , 20};
            int k = 20;

            Console.WriteLine(Result(numbers, k)); ;
            Console.ReadKey();
        }
    }
}
