# 33. Search in Rotated Sorted Array
# There is an integer array nums sorted in ascending order (with distinct values).
#P rior to being passed to your function, nums is possibly left rotated at an unknown index 
# k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]]
# (0-indexed). For example, [0,1,2,4,5,6,7] might be left rotated by 3 indices and become [4,5,6,7,0,1,2].
# Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
# You must write an algorithm with O(log n) runtime complexity.

class Solution(object):
    def search(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        left = 0
        right = len(nums) - 1
        mid = 0
        while (left <= right):
            mid = (left + right) / 2
            if (nums[mid] == target):
                return mid
            elif (nums[left] <= nums[mid]):
                # left sorted
                if (nums[left] <= target and target < nums[mid]):
                    right = mid - 1
                else:
                    left = mid + 1
            elif (nums[right] > nums[mid]):
                # right sorted
                if (nums[right] >= target and target > nums[mid]):
                    left = mid + 1
                else:
                    right = mid - 1
        return -1
    
solution = Solution()
print(solution.search([4,5,6,7,0,1,2], 0)) # 4