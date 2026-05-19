// 3111. Minimum Number of Rectangles to Cover Points
// You are given a 2D integer array points, where points[i] = [xi, yi]. You are also given an integer w. Your task is to cover all the given points with rectangles.
// Each rectangle has its lower end at some point (x1, 0) and its upper end at some point (x2, y2), where x1 <= x2, y2 >= 0, and the condition x2 - x1 <= w must be satisfied for each rectangle.
// A point is considered covered by a rectangle if it lies within or on the boundary of the rectangle.
// Return an integer denoting the minimum number of rectangles needed so that each point is covered by at least one rectangle.
// Note: A point may be covered by more than one rectangle.

namespace MinRectangles {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.MinRectanglesToCoverPoints([[1, 2], [2, 3], [3, 4]], 1);
            Console.WriteLine(result);
        }
    }
    class Solution {
        public int MinRectanglesToCoverPoints(int[][] points, int w) {
            int l = 0;
            int r = 1;
            int i = 0;
            int count = 1;
            List<int> pointArray = new List<int>();
            foreach (int[] point in points) {
                pointArray.Add(point[0]);
            }
            if (pointArray.Count() == 0) return 0;
            pointArray.Sort();
            while (r < pointArray.Count()) {
                if (pointArray[l] + w >= pointArray[r]) {
                    r++;
                } else {
                    l = r;
                    r++;
                    count++;
                }
            }
            return count;
        }
    }
}