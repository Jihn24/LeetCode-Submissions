// 1829. Maximum XOR for Each Query
// You are given a 0-indexed array nums consisting of n positive integers. 
// You are also given a 0-indexed array queries consisting of m non-negative integers. 
// The answer to the jth query is the maximum bitwise XOR value of queries[j] and xi, 
// where xi is an element of nums that you can choose. In other words, the answer 
// to the jth query is max(queries[j] XOR nums[0], queries[j] XOR nums[1], ..., 
// queries[j] XOR nums[n - 1]). Return an array answer where answer.length == m 
// and answer[j] is the answer to the jth query.

namespace MaxXOR {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.GetMaximumXor(new int[] { 0, 1, 2, 3 }, 2);
            Console.WriteLine(string.Join(", ", result));
        }
    }
    class Solution {
        public int[] GetMaximumXor(int[] nums, int maximumBit) {
            int[] k = new int[nums.Length];
            int i = nums.Length - 1;
            int xOR = 0;
            int maxK = (int)Math.Pow(2, maximumBit) - 1;
            for (int j = 0; j < nums.Length; j++) {           
                xOR ^= nums[j]; 
                k[i] = (maxK) ^ xOR;
                i--;         
            }
            return k;
        }
    }
}