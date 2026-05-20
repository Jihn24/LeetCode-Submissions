// 485. Max Consecutive Ones
// Given a binary array nums, return the maximum number of consecutive 1's in the array.

class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int count = 0, max = 0;
        for(auto i: nums){
            if(i == 1){
                count++;
            }
            else{
                count = 0;
            }

            if(count > max){
                max = count;
            }
        }

        return max;
    }
};