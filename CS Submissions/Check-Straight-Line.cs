// 1232. Check If It Is a Straight Line
// You are given an array coordinates, coordinates[i] = [x, y], where [x, y] 
// represents the coordinate of a point. Check if these points make a straight line in the XY plane. 

namespace CheckStraightLine {
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.CheckStraightLine(new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 } });
            Console.WriteLine(result);
        }
    }

    class Solution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 1) return true;
            int x1 = coordinates[0][0];
            int y1 = coordinates[0][1];
            int x2 = coordinates[1][0];
            int y2 = coordinates[1][1];

            for (int i = 1; i < coordinates.Length; i++)
            {
                int x = coordinates[i][0];
                int y = coordinates[i][1];
                if ((y2 - y1) * (x - x1) != (y - y1) * (x2 - x1)) return false;
            }
            return true;
        }
    }
}