// 1829. Maximum XOR for Each Query
// You are given a 0-indexed array nums consisting of n positive integers. 
// You are also given a 0-indexed array queries consisting of m non-negative integers. 
// The answer to the jth query is the maximum bitwise XOR value of queries[j] and xi, 
// where xi is an element of nums that you can choose. In other words, the answer 
// to the jth query is max(queries[j] XOR nums[0], queries[j] XOR nums[1], ..., 
// queries[j] XOR nums[n - 1]). Return an array answer where answer.length == m 
// and answer[j] is the answer to the jth query.

class Solution {
    public int[] getMaximumXor(int[] nums, int maximumBit) {
        int[] k = new int[nums.length];
        int i = nums.length - 1;
        int xOR = 0;
        int maxK = (int)Math.pow(2, maximumBit) - 1;
        for (int j = 0; j < nums.length; j++) {           
            xOR ^= nums[j]; 
            k[i] = (maxK) ^ xOR;
            i--;         
        }
        return k;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        int[] nums = {0,1,1,3};
        int maximumBit = 2;
        int[] result = solution.getMaximumXor(nums, maximumBit);
        for (int i : result) {
            System.out.println(i);
        }
    }
}