// 1470. Shuffle the Array
// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
// Return the array in the form [x1,y1,x2,y2,...,xn,yn].

namespace Shuffle_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            Solution solution = new Solution();
            int[] result = solution.Shuffle(nums, n);
            Console.WriteLine(string.Join(", ", result));
        }
    }
    public class Solution {
        public int[] Shuffle(int[] nums, int n) {
            int[] ans = new int[nums.Length];
            int j = 0;
            for(int i = 0; i < n; i++) {
                ans[j] = nums[i];
                ans[j+1] = nums[i+n];
                j += 2;
            }
            return ans;
        }
    }
}

