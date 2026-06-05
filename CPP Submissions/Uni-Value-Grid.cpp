// 2033. Minimum Operations to Make a Uni-Value Grid
// You are given a 2D integer grid of size m x n and an integer x. In one operation, you can add x to or subtract x from any element in the grid.
// A uni-value grid is a grid where all the elements of it are equal.
// Return the minimum number of operations to make the grid uni-value. If it is not possible, return -1.

class Solution {
public:
    int minOperations(vector<vector<int>>& grid, int x) {
        vector<int>values(grid.size() * grid[0].size());
        int i = 0;
        int r = grid.front().front() % x;
        for (auto row : grid) {
            for (int cell : row) {
                values[i] = cell;
                i++;
                if (cell % x != r) {
                    return -1;
                }
            }
        }

        //median
        sort(values.begin(), values.end());
        int median = values[values.size() / 2];

        //solution

        int minimum = 0;
        for (int value : values) {
            minimum += abs(value - median) / x;
        }

        return minimum;
    }
};