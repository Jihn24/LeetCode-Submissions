# 1539. Kth Missing Positive Number
# Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
# Return the kth positive integer that is missing from this array.

class Solution(object):
    def findKthPositive(self, arr, k):
        """
        :type arr: List[int]
        :type k: int
        :rtype: int
        """
        left = 0
        right = len(arr) - 1
        mid = 0

        while(left <= right):
            mid = (left + right) // 2

            if (arr[mid] - mid - 1 < k):
                left = mid + 1
            else:
                right = mid - 1
        return left + k
        

solution = Solution()
print(solution.findKthPositive([2,3,4,7,11], 5)) # 9