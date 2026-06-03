// 1929. Concatenation of Array
// Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
// Specifically, ans is the concatenation of two nums arrays.
// Return the array ans.

namespace Concatenation_of_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1 };
            Solution solution = new Solution();
            int[] result = solution.GetConcatenation(nums);
            Console.WriteLine(string.Join(", ", result));
        }
    }

    public class Solution {
        public int[] GetConcatenation(int[] nums) {
            int n = nums.Length;
            int[] ans = new int[2 * n];
            for(int i = 0; i < n; i++) {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }
            return ans;
        }
    }
}