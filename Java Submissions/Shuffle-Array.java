// 1470. Shuffle the Array
// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
// Return the array in the form [x1,y1,x2,y2,...,xn,yn].

class Solution {
    public int[] shuffle(int[] nums, int n) {
        int[] ans = new int[nums.length];
        int j = 0;
        for(int i = 0; i < n; i++) {
            ans[j] = nums[i];
            ans[j+1] = nums[i+n];
            j += 2;
        }
        return ans;
    }

    public static void main(String[] args) {
        var solution = new Solution();
        int[] output = solution.shuffle(new int[]{2, 5, 1, 3, 4, 7}, 3);
        for (int i : output) {
            System.out.print(i + " ");
        }
    }
}
