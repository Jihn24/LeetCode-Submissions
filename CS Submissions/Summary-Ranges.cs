// 228 Summary Ranges
// You are given a sorted unique integer array nums. Return the smallest sorted list of ranges that cover all 
// the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, 
// and there is no integer x such that x is in one of the ranges but not in nums.

namespace SummaryRanges {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 });
            foreach (string s in result) {
                Console.WriteLine(s);
            }
        }
    }
    // Second attempt, cleaner code runs faster but more memory usage because of the string concatenation
    public class Solution {
        public IList<string> SummaryRanges(int[] nums) {
            var output = new List<string>();
            int r = 1;
            int l = 0;
            if (nums.Length == 1) {
                output.Add(Convert.ToString(nums[0]));
                return output;
            }
            while (l < nums.Length) {
                if (nums[r] - nums[l] != r - l && r == l + 1) {
                    output.Add(Convert.ToString(nums[l]));
                    l++;
                    r++;
                }
                else if (nums[r] - nums[l] != r - l) {
                    output.Add(nums[l] + "->" + nums[r - 1]);
                    l = r;
                    r = l + 1;
                }
                else {
                    r++;
                }
                if (r == nums.Length) {
                    if (nums[r-1] - nums[l] != r - l && r == l + 1) {
                    output.Add(Convert.ToString(nums[l]));
                    }
                    else if (nums[r-1] - nums[l] != r - l) {
                    output.Add(nums[l] + "->" + nums[r - 1]);
                    }
                break;
                }
            }
            return output;
        }
    }
    // class Solution {
    //     public IList<string> SummaryRanges(int[] nums) {
    //         List<string> output = new List<string>();
    //         int r = 1;
    //         int l = 0;
    //         int i = 0;
    //         if (nums.Length == 1) {
    //             output.Add(Convert.ToString(nums[0]));
    //             return output;
    //         }
    //         while (l < nums.Length) {
    //             if (nums[r] - nums[l] != r - l && r == l + 1) {
    //                 output.Add(Convert.ToString(nums[l]));
    //                 l++;
    //                 r++;
    //                 i++;
    //             }
    //             else if (nums[r] - nums[l] != r - l) {
    //                 output.Add(nums[l] + "->" + nums[r - 1]);
    //                 l = r;
    //                 r = l + 1;
    //                 i++;
    //             }
    //             else {
    //                 r++;
    //             }
    //             if (r == nums.Length) {
    //                 if (nums[r-1] - nums[l] != r - l && r == l + 1) {
    //                 output.Add(Convert.ToString(nums[l]));
    //                 }
    //                 else if (nums[r-1] - nums[l] != r - l) {
    //                 output.Add(nums[l] + "->" + nums[r - 1]);
    //                 }
    //             break;
    //             }
    //         }
    //         return output;
    //     }
    // }
}
