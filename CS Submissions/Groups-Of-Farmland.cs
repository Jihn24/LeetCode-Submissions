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


namespace GroupsOfFarmland {
    class Program {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.FindFarmland([[1, 0, 0], [0, 1, 1], [0, 1, 1]]);
            foreach (var group in result) {
                Console.WriteLine(string.Join(", ", group));
            }
        }
    }

    // Second attempt is much faster and simpler. It finds the bottom right corner of the farmland and sets the land to trees so it won't be searched again.

    public class Solution {
        public int[][] FindFarmland(int[][] land) {
            List<int[]> output = new List<int[]>();
            int m = land.Length;
            int n = land[0].Length;
            for (int i = 0; i < m; i++) {            
                for (int j = 0; j < n; j++) {
                    // If farmland start a search for the size and set the land to trees for future loops to not search it again
                    if (land[i][j] == 1) {
                        int[] coords = FindBottomRight(land, i, j);
                        output.Add(coords);
                    } 
                }
            }
            int[][] outputList = output.ToArray();
            return outputList;
        }   

        public int[] FindBottomRight(int[][] land, int row, int col) {
            int m = land.Length;
            int n = land[0].Length;

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
            return new int[] {row, col, r - 1, c - 1 };
        } 
    }

    // First attempt was exceedingly slow and complex.

    // class Solution {
    //     public int[][] FindFarmland(int[][] land) {
    //         List<int[]> output = new List<int[]>();
    //         int m = land.Length;
    //         int n = land[0].Length;
    //         bool farmRight = false;
    //         bool farmDown = false;
    //         int r1 = 0;
    //         int r2 = 0;
    //         int c1 = 0;
    //         int c2 = 0;
    //         bool group = false;
    //         for (int i = 0; i < m; i++) {            
    //             for (int j = 0; j < n; j++) {
    //                 // If farmland start a search for the size and set the land to trees for future loops to not search it again
    //                 if (land[i][j] == 1) {
    //                     r1 = i;
    //                     c1 = j;
    //                     r2 = r1;
    //                     c2 = c1;
    //                     farmRight = true;
    //                     farmDown = true;
    //                     group = true;
    //                 }                
    //                 // Check to the right until no longer farm
    //                 while (farmRight) {
    //                     if (r2 + 1 < land.Length) {
    //                         if (land[r2 + 1][c2] == 1) {
    //                             r2++;
    //                         }
    //                         else {
    //                             farmRight = false;
    //                         }
    //                     } else {
    //                         farmRight = false;
    //                     }
    //                 }
    //                 // Check row below from left to furthest right
    //                 while (farmDown) {
    //                     if (c2 + 1 < land[r2].Length) {
    //                         if (land[r2][c2 + 1] == 1) {
    //                             c2++;
    //                         }
    //                         else {
    //                             farmDown = false;
    //                         }
    //                     }
    //                     else {
    //                         farmDown = false;
    //                     }
    //                 }
    //                 for (int k = r1; k <= r2; k++) {
    //                     for (int l = c1; l <= c2; l++) {
    //                         land[k][l] = 0;
    //                     }
    //                 }
    //                 // Group is start point to furthest right and down
    //                 if (group) {
    //                     output.Add([r1, c1, r2, c2]);
    //                     group = false;
    //                 }
    //                 if (r2 == land.Length - 1 && c2 == land[0].Length - 1) {
    //                     goto ExitLoops;
    //                 }
    //             }
    //         }
    //         ExitLoops:
    //         int[][] outputList = output.ToArray();
    //         return outputList;
    //     }    
    // }
}