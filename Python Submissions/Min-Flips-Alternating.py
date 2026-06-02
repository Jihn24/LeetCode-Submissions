# 1897. Minimum Number of Flips to Make the Binary String Alternating
# You are given a binary string s. You can perform two types of operations on the string any number of times:
# 1. Type-1: Remove the character at the start of the string s and append it to the end of the string.
# 2. Type-2: Pick any character in s and flip its value, if it is '0' convert it to '1' and vice-versa.
# Return the minimum number of type-2 operations you need to perform such that s becomes alternating. 
# The string is called alternating if no two adjacent characters are equal. For example, the string "010" 
# is alternating, while the string "0100" is not.

class Solution(object):
    def minFlips(self, s):
        """
        :type s: str
        :rtype: int
        """
        missZero = 0
        missOne = 0    
        current = 0 
        n = len(s)
        output = n
        doubleS = s + s
        for i in range(len(doubleS)):
            # Pattern 01010...
            current = (int)(doubleS[i])
            if (current == i % 2):
                missOne += 1          
            else:
                 missZero += 1
            if (i >= n):
                if (current == (i - n) % 2):
                    missOne -= 1
                else:
                    missZero -= 1
                output = min(output, missOne, missZero)                
        return output
        
solution = Solution()
print(solution.minFlips("111000")) # 2