// 1539. Kth Missing Positive Number
// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
// Return the kth positive integer that is missing from this array.

class Solution {
    public int findKthPositive(int[] arr, int k) {
        int left = 0;
        int right = arr.length - 1;
        int mid;

        while(left <= right) {
            mid = (left + right) / 2;

            if (arr[mid] - mid - 1 < k) {
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }   
        return left + k; 
    }

    public static void main(String[] args) {
        var solution = new Solution();
        System.out.println(solution.findKthPositive(new int[]{2, 3, 4, 7, 11}, 5));
        System.out.println(solution.findKthPositive(new int[]{1, 2, 3, 4}, 2));
    }
}