// 485. Max Consecutive Ones
// Given a binary array nums, return the maximum number of consecutive 1's in the array.

namespace MaxConsecutiveOnes {
    // First attempt, O(n) time and O(1) space
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            Console.WriteLine(solution.FindMaxConsecutiveOnes(new int[] {1,1,0,1,1,1})); // 3
        }
    }

    class Solution {
        public int FindMaxConsecutiveOnes(int[] nums) {
            int max = 0;
            int cur = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 1 && cur >= max) {
                    cur++;
                    max = cur;
                } else if(nums[i] == 1 && cur < max) {
                    cur++;
                } else {
                    cur = 0;
                }
            }
            return max;
        }
    }
}