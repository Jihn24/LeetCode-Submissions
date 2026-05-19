// 11. Container With Most Water
// You are given an integer array height of length n. There are n vertical lines drawn such that the 
// two endpoints of the ith line are (i, 0) and (i, height[i]).
// Find two lines that together with the x-axis form a container, such that the container contains the most water.
// Return the maximum amount of water a container can store.
// Notice that you may not slant the container

class Solution {
    public int maxArea(int[] height) {
        int l = 0;
        int r = height.length - 1;
        int output = 0;
        while (l < r) {
            output = Math.max(output, (Math.min(height[l], height[r]) * (r - l)));
            if (height[l] > height[r]) {
                r--;
            }
            else {
                l++;
            }
        }
        return output;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.maxArea(new int[]{1,8,6,2,5,4,8,3,7})); // 49
    }
}