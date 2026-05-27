// 1539. Kth Missing Positive Number
// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
// Return the kth positive integer that is missing from this array.

class Solution {
public:
    int findKthPositive(vector<int>& arr, int k) {
        int left = 0;
        int right = arr.size() - 1;
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
};