// 228 Summary Ranges
// You are given a sorted unique integer array nums. Return the smallest sorted list of ranges that cover all 
// the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, 
// and there is no integer x such that x is in one of the ranges but not in nums.

class Solution {
    public java.util.List<String> summaryRanges(int[] nums) {
        java.util.ArrayList<String> output = new java.util.ArrayList<>();
        int r = 1;
        int l = 0;
        if (nums.length == 0) return output;
        if (nums.length == 1) {
            output.add(String.valueOf(nums[0]));
            return output;
        }
        while (l < nums.length) {
            if (nums[r] - nums[l] != r - l && r == l + 1) {
                output.add(String.valueOf(nums[l]));
                l++;
                r++;
            }
            else if (nums[r] - nums[l] != r - l) {
                output.add(nums[l] + "->" + nums[r - 1]);
                l = r;
                r = l + 1;
            }
            else {
                r++;
            }
            if (r == nums.length) {
                if (nums[r-1] - nums[l] != r - l && r == l + 1) {
                output.add(String.valueOf(nums[l]));
                }
                else if (nums[r-1] - nums[l] != r - l) {
                output.add(nums[l] + "->" + nums[r - 1]);
                }
            break;
            }
        }
        return output;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        int[] nums = {0,1,2,4,5,7};
        java.util.List<String> result = solution.summaryRanges(nums);
        System.out.println(result); // ["0->2","4->5","7"]
    }
}
