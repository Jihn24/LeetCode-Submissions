# 1992. Find All Groups of Farmland
# You are given a 0-indexed m x n binary matrix land, where a 0 represents a hectare of forested land and a 1 
# represents a hectare of farmland. To keep the land organized, there are designated rectangular areas of farmland, 
# and there are no forested hectares included in these designated farmland areas. If land[i][j] == 1, then the hectare 
# at coordinates (i, j) is farmland. A group of farmland is a rectangular area of farmland that is fully connected. 
# More formally, a group of farmland is a set of cells (i, j) such that land[i][j] == 1 and all the cells in the rectangle 
# defined by the upper left cell (r1, c1) and the lower right cell (r2, c2) are also 1.
# Return a 2D array containing the coordinates of the upper left and lower right cell of each group of farmland in land. 
# The coordinates of the upper left cell of the ith group should be answer[i][0] and the coordinates of the lower right cell 
# should be answer[i][1]. If there are no groups of farmland, return an empty array. The groups may be returned in any order. 

class Solution(object):
    def findBottomRight(self, land, row, col):
        m = len(land)
        n = len(land[0])

        r = row
        c = col

        while(r < m and land[r][col] == 1):
            r += 1
        while(c < n and land[row][c] == 1):
            c += 1

        for i in range(row, r):
            for j in range(col, c, 1):
                land[i][j] = 0
        return [row, col, r - 1, c - 1]
    
    def findFarmland(self, land):
        """
        :type land: List[List[int]]
        :rtype: List[List[int]]
        """
        output = []
        m = len(land)
        n = len(land[0])
        for i in range(m):            
            for j in range(n):
                # If farmland start a search for the size and set the land to trees for future loops to not search it again
                if (land[i][j] == 1):
                    coords = self.findBottomRight(land, i, j)
                    output.append(coords)
        return output

        
solution = Solution()
print(solution.findFarmland([[1,0,0],[0,1,1],[0,1,1]])) # [[0,0,0,0],[1,1,2,2]]