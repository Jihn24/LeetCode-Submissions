// 3852 Smallest Pair with Different Frequencies
// You are given an integer array nums.
// Consider all pairs of distinct values x and y from nums such that:
//     x < y
//     x and y have different frequencies in nums.
// Among all such pairs:
//     Choose the pair with the smallest possible value of x.
//     If multiple pairs have the same x, choose the one with the smallest possible value of y.
// Return an integer array [x, y]. If no valid pair exists, return [-1, -1].

namespace SmallestPair {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.MinDistinctFreqPair(new int[] { 1, 1, 1, 2, 2, 3 });
            Console.WriteLine(string.Join(", ", result));
        }
    }

    class Solution {
        public int[] MinDistinctFreqPair(int[] nums) {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            
            Array.Sort(nums);
            int x = nums[0];
            foreach (int num in nums) {
                if (!freq.ContainsKey(num)) freq[num] = 1;
                else freq[num]++;
            }
            foreach (var number in freq) {
                if (number.Value != freq[x]) return new int[] { x, number.Key };
            }

            return new int[] { -1, -1 };
        }
    }
}