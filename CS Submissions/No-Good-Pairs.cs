// 3143. Find number of good pairs 1
// You are given 2 integer arrays nums1 and nums2 of lengths n and m respectively. You are also given a positive integer k.
// A pair (i, j) is called good if nums1[i] is divisible by nums2[j] * k (0 <= i <= n - 1, 0 <= j <= m - 1).
// Return the total number of good pairs

namespace NoGoodPairs {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.NumberOfPairs(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, 1);
            Console.WriteLine(result);
        }
    }

    class Solution {
        public int NumberOfPairs(int[] nums1, int[] nums2, int k) {
            // Brute force solution to solve first, will try something faster after
            int output = 0;
            for (int i = 0; i < nums1.Length; i++) {
                for (int j = 0; j < nums2.Length; j++) {
                    if (nums1[i] % (nums2[j] * k) == 0) output++;
                }
            }
            return output;
        }
    }
}