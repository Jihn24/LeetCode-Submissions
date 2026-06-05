// 2033. Minimum Operations to Make a Uni-Value Grid
// You are given a 2D integer grid of size m x n and an integer x. In one operation, you can add x to or subtract x from any element in the grid.
// A uni-value grid is a grid where all the elements of it are equal.
// Return the minimum number of operations to make the grid uni-value. If it is not possible, return -1.

import java.util.Arrays;

class Solution {
    public int minOperations(int[][] grid, int x) {
        int[] values = new int[grid.length * grid[0].length];
        int i = 0;
        for (var row : grid) {
            for (var cell : row) {
                values[i] = cell;
                i++;
            }
        }

        //feasibility
        int r = values[0] % x;
        for (int value : values) {
            if (value % x != r) {
                return -1;
            }
        }

        //median
        Arrays.sort(values);
        int median = values[values.length / 2];

        //solution

        int minimum = 0;
        for (int value : values) {
            minimum += Math.abs(value - median) / x;
        }

        return minimum;           
    }

    public static void main(String[] args) {
        var solution = new Solution();
        System.out.println(solution.minOperations(new int[][]{{1, 2}, {3, 4}}, 1)); // 2
        System.out.println(solution.minOperations(new int[][]{{1, 10, 100}}, 1)); // -1
    }
}
