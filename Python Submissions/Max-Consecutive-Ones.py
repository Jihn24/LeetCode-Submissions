# 485. Max Consecutive Ones
# Given a binary array nums, return the maximum number of consecutive 1's in the array.

class Solution(object):
    def findMaxConsecutiveOnes(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        max = 0
        cur = 0
        for i in range (len(nums)):
            if nums[i] == 1 and cur >= max:
                cur += 1
                max = cur
            elif nums[i] == 1 and cur < max:
                cur += 1
            else:
                cur = 0
        return max
        
solution = Solution()
print(solution.findMaxConsecutiveOnes([1,1,0,1,1,1])) # 3