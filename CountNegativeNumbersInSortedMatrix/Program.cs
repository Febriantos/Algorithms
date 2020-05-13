using System;

namespace CountNegativeNumbersInSortedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[1][] { new int[1] { -1 } };

            // int[][] grid = new int[4][] { 
            //                          new int [4] { 4, 3, 2, -1 }
            //                        , new int [4] { 3, 2, 1, -1 }
            //                        , new int [4] { 1, 1, -1, -2 }
            //                        , new int [4] { -1, -1, -2, -3 } };

            var result = CountNegatives(grid);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
        public static int CountNegatives(int[][] grid)
        {
            int result = 0;
            if (grid.Length <= 0 || grid[0].Length > 100)
                return 0;

            foreach (var row in grid)
            {
                foreach (var cell in row)
                {
                    if (cell < 0)
                        result++;
                }
            }

            return result;
        }


    }
}
