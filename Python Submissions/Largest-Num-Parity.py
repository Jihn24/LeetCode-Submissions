# 2231. Largest Number After Digit Swaps by Parity
# You are given a positive integer num. You may swap any two digits of num that have the same parity (i.e. both odd digits or both even digits).
# Return the largest possible value of num after any number of swaps.

class Solution(object):
    def largestInteger(self, num):
        """
        :type num: int
        :rtype: int
        """
        number = str(num)
        output = ""
        evens = []
        odds = []
        parity = [False for _ in range(len(number))]
        evenIndex = 0
        oddIndex = 0

        for i in range(len(number)):
            if (int(number[i]) % 2 == 0):
                parity[i] = True
                evens.append(number[i])
                evenIndex += 1
            else:
                parity[i] = False
                odds.append(number[i])
                oddIndex += 1

        odds.sort()
        evens.sort()

        for i in range(len(number)):
            if (parity[i]):
                output += str(evens[evenIndex - 1])
                evenIndex -= 1
            else:
                output += str(odds[oddIndex - 1])
                oddIndex -= 1

        return int(output)
        
solution = Solution()
print(solution.largestInteger(1234))