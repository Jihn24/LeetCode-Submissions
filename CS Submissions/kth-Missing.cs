// 1539. Kth Missing Positive Number
// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
// Return the kth positive integer that is missing from this array.

namespace KthMissing {
    class Program {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.FindKthPositive(new int[] { 2, 3, 4, 7, 11 }, 5);
            Console.WriteLine(result);
        }

    }

    // Second attempt, O(log n) time complexity, O(1) space complexity

    public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;

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
}

    // First attempt, O(n) time complexity, O(1) space complexity

    // class Solution {
    //     public int FindKthPositive(int[] arr, int k) {
    //         int missed = 0;
    //         int integer = 1;

    //         for (int i = 0; i < arr.Length; i++) {
    //             while (integer != arr[i]) {     
    //                 if (missed == k) {
    //                     break;
    //                 }
    //                 missed++;  
    //                 integer++;                               
    //             }
    //             if (missed == k) break;
    //             integer++;
    //         }

    //         integer += k - missed;
        
    //         return integer - 1;
    //     }
    // }
}