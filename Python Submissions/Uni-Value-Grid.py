# 2033. Minimum Operations to Make a Uni-Value Grid
# You are given a 2D integer grid of size m x n and an integer x. In one operation, you can add x to or subtract x from any element in the grid.
# A uni-value grid is a grid where all the elements of it are equal.
# Return the minimum number of operations to make the grid uni-value. If it is not possible, return -1.

class Solution(object):
    def minOperations(self, grid, x):
        """
        :type grid: List[List[int]]
        :type x: int
        :rtype: int
        """
        values = []
        for row in grid:
            for cell in row:
                values.append(cell)

        # feasibility
        r = values[0] % x
        for value in values:
            if value % x != r:
                return -1

        # median
        values.sort()
        median = values[len(values) // 2]

        # solution

        minimum = 0
        for value in values:
            minimum += abs(value - median) // x

        return minimum
        
solution = Solution()
print(solution.minOperations([[2,4],[6,8]], 2)) # 4