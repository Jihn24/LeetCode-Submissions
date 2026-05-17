// 2587. Maximize the Prefix Score of an Array
// You are given a 0-indexed integer array nums. The prefix score of nums is the number of indices i such that the sum 
// of the first i + 1 elements of nums is strictly greater than 0. You can rearrange the elements of nums in any order. 
// Return the maximum prefix score of nums after the rearrangement.

var solution = new Solution();
var result = solution.MaxScore(new int[] { 2, -1, 0, 3, -2 });
Console.WriteLine(result);

public class Solution {
    public int MaxScore(int[] nums) {
        int[] prefix = nums;
        Array.Sort(prefix);
        Array.Reverse(prefix);
        int score = 0;
        long value = 0;
        for (int i = 0; i < prefix.Length; i++) {
            value += prefix[i];
            if (value > 0) {
                score ++;
            } else {
                break;
            }
        }
        return score;
    }
}