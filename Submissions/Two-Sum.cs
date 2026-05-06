var solution = new Solution();
var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine(result[0] + ", " + result[1]);

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length - 1; i++) {
            for  (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return [i, j];
                }
            }
        }
        return [-1, -1];
    }
}

