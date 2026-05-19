# 11. Container With Most Water
# You are given an integer array height of length n. There are n vertical lines drawn such that the 
# two endpoints of the ith line are (i, 0) and (i, height[i]).
# Find two lines that together with the x-axis form a container, such that the container contains the most water.
# Return the maximum amount of water a container can store.
# Notice that you may not slant the container

class Solution(object):
    def maxArea(self, height):
        """
        :type height: List[int]
        :rtype: int
        """
        l = 0
        r = len(height) - 1
        output = 0
        while (l < r): 
            output = max(output, (min(height[l], height[r]) * (r - l)))
            if (height[l] > height[r]):
                r -= 1
            else:
                l += 1
        return output
        

solution = Solution()
print(solution.maxArea([1,8,6,2,5,4,8,3,7])) # 49