// 11. Container With Most Water
// You are given an integer array height of length n. There are n vertical lines drawn such that the 
// two endpoints of the ith line are (i, 0) and (i, height[i]).
// Find two lines that together with the x-axis form a container, such that the container contains the most water.
// Return the maximum amount of water a container can store.
// Notice that you may not slant the container

var solution = new Solution();
var result = solution.MaxArea(new int[] {1,8,6,2,5,4,8,3,7});
Console.WriteLine(result); // 49

public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int output = 0;
        while (l < r) {
            output = Math.Max(output, (Math.Min(height[l], height[r]) * (r - l)));
            if (height[l] > height[r]) {
                r--;
            }
            else {
                l++;
            }
        }
        return output;
    }
}