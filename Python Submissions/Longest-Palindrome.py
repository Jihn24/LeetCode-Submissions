# 5. Longest Palindromic Substring
# Given a string s, return the longest palindromic substring in s.

class Solution(object):
    def longestPalindrome(self, s):
        """
        :type s: str
        :rtype: str
        """
        T = "^#" + ("#".join(list(s))) + "#$"
        n = len(T)
        P = [0] * n
        C = 0
        R = 0

        for i in range(1, n-1):
            P[i] = min(R - i, P[2*C - i]) if (R > i) else 0
            while T[i + 1 + P[i]] == T[i - 1 - P[i]]:
                P[i] += 1

                if i + P[i] > R:
                    C = i
                    R = i + P[i]      

        max_len = max(P)
        center_index = P.index(max_len)
        return s[(center_index - max_len) // 2 : (center_index + max_len) // 2]
    
solution = Solution()
print(solution.longestPalindrome("babad")) # "aba" or "bab"