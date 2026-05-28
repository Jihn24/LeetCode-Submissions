# 1711. Count Good Meals
# A good meal is a meal that contains exactly two different food items with a sum of deliciousness equal to a power of two. 
# You can pick any two different foods to make a good meal. Given an array of integers deliciousness where deliciousness[i] 
# is the deliciousness of the ith item of food, return the number of different good meals you can make from this list 
# modulo 10^9 + 7. Note that items with different indices are considered different even if they have the same deliciousness value.

class Solution(object):
    def countPairs(self, deliciousness):
        """
        :type deliciousness: List[int]
        :rtype: int
        """
        count = 0    
        MOD = 1000000007
        freq = {}

        for d in deliciousness:
            power = 1
            while (power <= 1 << 21):
                value = power - d
                if value in freq:
                    count = (count + freq[value]) % MOD

                power = power << 1

            if d in freq:
                freq[d] += 1
            else:
                freq[d] = 1

        return count
        
solution = Solution()
print(solution.countPairs([1,3,5,7,9])) # 4