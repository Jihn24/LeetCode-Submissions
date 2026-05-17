// 3142. Check if Grid Satisfies Conditions
// You are given a 2D matrix grid of size m x n. You need to check if each cell grid[i][j] is:
// Equal to the cell below it, i.e. grid[i][j] == grid[i + 1][j] (if it exists).
// Different from the cell to its right, i.e. grid[i][j] != grid[i][j + 1] (if it exists).
// Return true if all the cells satisfy these conditions, otherwise, return false.

var solution = new Solution();
var result = solution.SatisfiesConditions([[0, 1, 0], [1, 0, 1], [0, 1, 0]]);
Console.WriteLine(result);

public class Solution {
    public bool SatisfiesConditions(int[][] grid) {
        for (int i = 0; i < grid.Length ; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (j < grid[0].Length - 1) {
                    if (grid[i][j] == grid[i][j+1]) return false;
                }
                if (i < grid.Length - 1) {
                    if (grid[i][j] != grid[i+1][j]) return false;
                }
            }
        }
        return true;
    }
}