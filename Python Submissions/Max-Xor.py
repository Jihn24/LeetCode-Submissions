# 1829. Maximum XOR for Each Query
# You are given a 0-indexed array nums consisting of n positive integers. 
# You are also given a 0-indexed array queries consisting of m non-negative integers. 
# The answer to the jth query is the maximum bitwise XOR value of queries[j] and xi, 
# where xi is an element of nums that you can choose. In other words, the answer 
# to the jth query is max(queries[j] XOR nums[0], queries[j] XOR nums[1], ..., 
# queries[j] XOR nums[n - 1]). Return an array answer where answer.length == m 
# and answer[j] is the answer to the jth query.

class Solution(object):
    def getMaximumXor(self, nums, maximumBit):
        """
        :type nums: List[int]
        :type maximumBit: int
        :rtype: List[int]
        """
        k = [0 for _ in range(len(nums))]
        i = len(nums) - 1
        xOR = 0
        maxK = 2 ** maximumBit - 1
        for j in range(len(nums)):           
            xOR ^= nums[j]
            k[i] = (maxK) ^ xOR
            i -= 1    
        return k
        
solution = Solution()
print(solution.getMaximumXor([0,1,1,3], 2)) # [0,3,2,3]