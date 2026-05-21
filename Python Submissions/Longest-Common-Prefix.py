# 3043. Find the Length of the Longest Common Prefix of Two Arrays
# You are given two arrays with positive integers arr1 and arr2.
# A prefix of a positive integer is an integer formed by one or more of its digits, starting from its leftmost digit. For example, 123 is a prefix of the integer 12345, while 234 is not.
# A common prefix of two integers a and b is an integer c, such that c is a prefix of both a and b. For example, 5655359 and 56554 have common prefixes 565 and 5655 while 1223 and 43456 do not have a common prefix.
# You need to find the length of the longest common prefix between all pairs of integers (x, y) such that x belongs to arr1 and y belongs to arr2.
# Return the length of the longest common prefix among all pairs. If no common prefix exists among them, return 0.

class Solution(object):
    def longestCommonPrefix(self, arr1, arr2):
        """
        :type arr1: List[int]
        :type arr2: List[int]
        :rtype: int
        """
        output = 0
        longest = float('-inf')
        prefix = set()

        for number in arr1:
            if number not in prefix:
                while number > 0:
                    prefix.add(number)
                    number //= 10
        
        for number in arr2:
            while number > 0:
                if number in prefix:
                    longest = max(longest, number)
                    break
                number //= 10
        
        output = len(str(longest)) if longest > 0 else 0
        return output
    
solution = Solution()
print(solution.longestCommonPrefix([123, 456, 789], [12, 45, 78])) # 2