using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleInterviewQuestion
{
    internal class Program
    {
        public static ArrayList boundaryOnes(int[,] island, ArrayList stayingOnes)
        {
            ArrayList boundaryOnes = new ArrayList();
            

            //Üst ve alt satırdaki 1'leri bulan döngü 
            for (int i = 0; i < island.GetLength(1); i++)
            {
                
                if (island[0, i] == 1)
                {
                    int[] coordinates = new int[] {0, i};
                    boundaryOnes.Add(coordinates);
                    stayingOnes.Add(coordinates);
                }
                    
                if (island[island.GetLength(0) - 1, i] == 1)
                {
                    int[] coordinates = new int[] { island.GetLength(0) - 1, i };
                    boundaryOnes.Add(coordinates);
                    stayingOnes.Add(coordinates);
                }
                    
            }

            //Sol ve sağ sütundaki 1'leri bulan döngü
            for (int i = 1; i < island.GetLength(0) - 1; i++)
            {
                if (island[i, 0] == 1)
                {
                    int[] coordinates = new int[] { i, 0 };
                    boundaryOnes.Add(coordinates);
                    stayingOnes.Add(coordinates);
                }

                if (island[i, island.GetLength(1) - 1] == 1)
                {
                    int[] coordinates = new int[] { i, island.GetLength(1) - 1 };
                    boundaryOnes.Add(coordinates);
                    stayingOnes.Add(coordinates);
                }
            }

            return boundaryOnes;
        }

        public static bool stayingOnesContains(int x, int y, ArrayList stayingOnes)
        {
            foreach (int[] stayOne in stayingOnes)
            {
                if (stayOne[0] == x && stayOne[1] == y)
                    return true;
            }
            return false;
        }
        public static void findPath(int x, int y, int[,] island, ArrayList stayingOnes)
        {
            //Yukarı bak
            if( x > 0 && island[x - 1, y] == 1)
            {
                int[] coordinates = new int[] { x - 1, y };
                if(!stayingOnesContains(x - 1, y, stayingOnes))
                {
                    stayingOnes.Add(coordinates);
                    findPath(x-1, y, island,stayingOnes);
                }
            }

            //Aşağı bak
            if (x < island.GetLength(0) - 1 && island[x + 1, y] == 1)
            {
                int[] coordinates = new int[] { x + 1, y };
                if (!stayingOnesContains(x + 1, y, stayingOnes))
                {
                    stayingOnes.Add(coordinates);
                    findPath(x + 1, y, island, stayingOnes);
                }
            }

            //Sola bak
            if (y > 0 && island[x, y - 1] == 1)
            {
                int[] coordinates = new int[] { x, y - 1 };
                if (!stayingOnesContains(x, y - 1, stayingOnes))
                {
                    stayingOnes.Add(coordinates);
                    findPath(x, y - 1, island, stayingOnes);
                }
            }

            //Sağa bak
            if ( y < island.GetLength(1) - 1 && island[x, y + 1] == 1)
            {
                int[] coordinates = new int[] { x, y + 1 };
                if (!stayingOnesContains(x, y + 1, stayingOnes))
                {
                    stayingOnes.Add(coordinates);
                    findPath(x, y + 1, island, stayingOnes);
                }
            }

        }
        public static int[,] removeIsland(int[,] island)
        {
            ArrayList stayingOnes = new ArrayList();

            foreach(int[] arrays in boundaryOnes(island, stayingOnes))
            {
                findPath(arrays[0], arrays[1], island, stayingOnes);
            }

            int[,] result = new int[island.GetLength(0), island.GetLength(1)];


            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    foreach (int[] stay in stayingOnes)
                    {
                        if (stay[0] == i && stay[1] == j)
                            result[i, j] = 1;
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[,] island = 
            {
                { 1, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 1 },
                { 0, 0, 1, 0, 1, 0 },
                { 1, 1, 0, 0, 1, 0 },
                { 1, 0, 1, 1, 0, 0 },
                { 1, 0, 0, 0, 0, 1 },
            };

            int[,] result = removeIsland(island);

            for(int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

