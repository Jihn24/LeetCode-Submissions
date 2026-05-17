// 1539. Kth Missing Positive Number
// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
// Return the kth positive integer that is missing from this array.

var solution = new Solution();
var result = solution.FindKthPositive(new int[] { 2, 3, 4, 7, 11 }, 5);
Console.WriteLine(result);

public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int missed = 0;
        int integer = 1;

        for (int i = 0; i < arr.Length; i++) {
            while (integer != arr[i]) {                                  
                Console.WriteLine(integer);
                if (missed == k) {
                    break;
                }
                missed++;  
                integer++;                               
            }
            if (missed == k) break;
            integer++;
        }

        integer += k - missed;
      
        return integer - 1;
    }
}

// Would like to try the follow up of achieving O(n) time complexity. 
// This solution is O(n + k) because in the worst case we have to iterate through the entire array and then count up to k missing integers.