# 228 Summary Ranges
# You are given a sorted unique integer array nums. Return the smallest sorted list of ranges that cover all 
# the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, 
# and there is no integer x such that x is in one of the ranges but not in nums.

class Solution(object):
    def summaryRanges(self, nums):
        """
        :type nums: List[int]
        :rtype: List[str]
        """
        output = []
        r = 1 
        l = 0
        if len(nums) == 0:
            return []
        if len(nums) == 1:
            return [str(nums[0])]
        while l < len(nums):
            if nums[r] - nums[l] != r - l and r == l + 1:
                output.append(str(nums[l]))
                l += 1
                r += 1
            elif nums[r] - nums[l] != r - l:
                output.append(str(nums[l]) + "->" + str(nums[r - 1]))
                l = r
                r = l + 1
            else:
                r += 1
            if r == len(nums):
                if nums[r-1] - nums[l] != r - l and r == l + 1:
                    output.append(str(nums[l]))
                elif nums[r-1] - nums[l] != r - l:
                    output.append(str(nums[l]) + "->" + str(nums[r - 1]))
                break
        return output
        
solution = Solution()
print(solution.summaryRanges([0,1,2,4,5,7])) # ["0->2","4->5","7"]