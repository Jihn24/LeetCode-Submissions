# 1710. Maximum Units on a Truck
# You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:
#     numberOfBoxesi is the number of boxes of type i.
#     numberOfUnitsPerBoxi is the number of units in each box of the type i.
# You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. 
# You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.
# Return the maximum total number of units that can be put on the truck.

class Solution(object):
    def maximumUnits(self, boxTypes, truckSize):
        """
        :type boxTypes: List[List[int]]
        :type truckSize: int
        :rtype: int
        """
        maximum = 0
        boxTypes.sort(key=lambda x: x[1], reverse = True)

        for boxCount,unitsPerBox in boxTypes:

            boxesToTake = min(truckSize, boxCount)

            maximum += (boxesToTake * unitsPerBox)
            truckSize -= boxesToTake
            if truckSize == 0:
                break
        return maximum
        
solution = Solution()
print(solution.maximumUnits([[1,3],[2,2],[3,1]], 4)) # 8