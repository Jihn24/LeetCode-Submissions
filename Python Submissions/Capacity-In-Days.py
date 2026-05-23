# 1011. Capacity To Ship Packages Within D Days
# A conveyor belt has packages that must be shipped from one port to another within D days. 
# The i-th package on the conveyor belt has a weight of weights[i]. Each day, we load the ship 
# with packages on the conveyor belt (in the order given by weights). We may not load more weight 
# than the maximum weight capacity of the ship. Return the least weight capacity of the ship that 
# will result in all the packages on the conveyor belt being shipped within D days.

class Solution(object):
    def shipWithinDays(self, weights, days):
        """
        :type weights: List[int]
        :type days: int
        :rtype: int
        """
        minViable = weights[0]
        maxViable = 0
        for weight in weights:
            maxViable += weight
            minViable = max(minViable, weight)
    
        currDays = 1
        if (days == 1):
            return maxViable
        currMinWeight = (minViable + maxViable) // 2
        currTestWeight = 0
        while minViable < maxViable:
            currDays = 1
            currTestWeight = 0
            force_break = False
            for weight in weights:
                if currTestWeight + weight <= currMinWeight:
                    currTestWeight += weight
                else: 
                    currDays += 1
                    currTestWeight = weight
                    if currDays > days:
                        minViable = currMinWeight + 1
                        currMinWeight = (minViable + maxViable) // 2
                        force_break = True
                        break
            if force_break:
                force_break = False
                continue
            maxViable = currMinWeight
            currMinWeight = (minViable + maxViable) // 2
        return minViable;  

solution = Solution()
print(solution.shipWithinDays([1,2,3,4,5,6,7,8,9,10], 5)) # 15