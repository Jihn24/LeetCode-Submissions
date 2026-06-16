# 2285. Maximum Total Importance of Roads
# There is a country of n cities numbered from 0 to n - 1. You are given a 2D integer array roads where roads[i] = [ai, bi] 
# indicates that there is a bidirectional road connecting cities ai and bi. The importance of a road is the sum of the values 
# of the two cities it connects. The value of a city is the number of roads that are connected to it. Return the maximum total 
# importance of all roads possible after assigning the values to the cities optimally.

class Solution(object):
    def maximumImportance(self, n, roads):
        """
        :type n: int
        :type roads: List[List[int]]
        :rtype: int
        """
        output = 0
        cities = [0 for _ in range(n)]

        # Loop through roads counting each occurance of each city, assign value to list
        for roadA, roadB in roads:
            cities[roadA] += 1
            cities[roadB] += 1

        # Order the cities and then assign values 1-n
        cities.sort()

        # Loop through each road and sum the importance using the array
        for i in range(n):
            output += cities[i] * (i + 1)
   
        return output
        
solution = Solution()
print(solution.maximumImportance(5, [[0,1],[1,2],[2,3],[0,2],[1,3]])) # 43