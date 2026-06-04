// 1992. Find All Groups of Farmland
// You are given a 0-indexed m x n binary matrix land, where a 0 represents a hectare of forested land and a 1 
// represents a hectare of farmland. To keep the land organized, there are designated rectangular areas of farmland, 
// and there are no forested hectares included in these designated farmland areas. If land[i][j] == 1, then the hectare 
// at coordinates (i, j) is farmland. A group of farmland is a rectangular area of farmland that is fully connected. 
// More formally, a group of farmland is a set of cells (i, j) such that land[i][j] == 1 and all the cells in the rectangle 
// defined by the upper left cell (r1, c1) and the lower right cell (r2, c2) are also 1.
// Return a 2D array containing the coordinates of the upper left and lower right cell of each group of farmland in land. 
// The coordinates of the upper left cell of the ith group should be answer[i][0] and the coordinates of the lower right cell 
// should be answer[i][1]. If there are no groups of farmland, return an empty array. The groups may be returned in any order. 

class Solution {
public:
    vector<vector<int>> findFarmland(vector<vector<int>>& land) {
        vector<vector<int>> output;
        int m = land.size();
        int n = land[0].size();
        for (int i = 0; i < m; i++) {            
            for (int j = 0; j < n; j++) {
                // If farmland start a search for the size and set the land to trees for future loops to not search it again
                if (land[i][j] == 1) {
                    vector<int> coords = FindBottomRight(land, i, j);
                    output.push_back(coords);
                } 
            }
        }
        return output;
    }   

public: 
    vector<int> FindBottomRight(vector<vector<int>> &land, int row, int col) {
        int m = land.size();
        int n = land[0].size();

        int r = row;
        int c = col;

        while(r < m && land[r][col] == 1) {
            r++;
        }
        while(c < n && land[row][c] == 1) {
            c++;
        }

        for (int i = row; i < r; i++) {
            for (int j = col; j < c; j++) {
                land[i][j] = 0;
            }
        }
        r--;
        c--;
        return {row, col, r, c};
    }
};