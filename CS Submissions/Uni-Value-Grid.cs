// 2033. Minimum Operations to Make a Uni-Value Grid
// You are given a 2D integer grid of size m x n and an integer x. In one operation, you can add x to or subtract x from any element in the grid.
// A uni-value grid is a grid where all the elements of it are equal.
// Return the minimum number of operations to make the grid uni-value. If it is not possible, return -1.

namespace UniValueGrid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] grid = new int[2][];
            grid[0] = new int[] { 1, 2, 3 };
            grid[1] = new int[] { 4, 5, 6 };
            int x = 1;

            Solution solution = new Solution();
            Console.WriteLine(solution.MinOperations(grid, x));
        }
    }
    public class Solution {
        public int MinOperations(int[][] grid, int x) {
            List<int> values = new List<int>();
            foreach(var row in grid) {
                foreach(var cell in row) {
                    values.Add(cell);
                }
            }

            //feasibility
            foreach(int value in values) {
                if ((value - values[0]) % x !=0) {
                    return -1;
                }
            }

            //median
            values.Sort();
            int median = values[values.Count() / 2];

            //solution

            int minimum = 0;
            foreach(int value in values) {
                minimum += Math.Abs(value - median) / x;
            }

            return minimum;
        }
    }
}