# 1232. Check If It Is a Straight Line
# You are given an array coordinates, coordinates[i] = [x, y], where [x, y] 
# represents the coordinate of a point. Check if these points make a straight line in the XY plane. 

class Solution(object):
    def checkStraightLine(self, coordinates):
        """
        :type coordinates: List[List[int]]
        :rtype: bool
        """
        if (len(coordinates) == 1):
            return True
        x1 = coordinates[0][0]
        y1 = coordinates[0][1]
        x2 = coordinates[1][0]
        y2 = coordinates[1][1]
        
        for i in range(len(coordinates)):
            x = coordinates[i][0]
            y = coordinates[i][1]
            if ((y2 - y1) * (x - x1) != (y - y1) * (x2 - x1)):
                return False
        return True
        
solution = Solution()
print(solution.checkStraightLine([[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]])) # True