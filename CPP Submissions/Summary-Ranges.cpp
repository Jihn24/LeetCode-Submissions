// 228 Summary Ranges
// You are given a sorted unique integer array nums. Return the smallest sorted list of ranges that cover all 
// the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, 
// and there is no integer x such that x is in one of the ranges but not in nums.

#include <vector>
#include <string>
using namespace std;

class Solution {
public:
    vector<string> summaryRanges(vector<int>& nums) {
        vector<string> output;
        int r = 1;
        int l = 0;
        if (nums.size() == 1) {
            output.push_back(to_string(nums[0]));
            return output;
        }
        while (l < nums.size()) {
            if (long(nums[r]) - long(nums[l]) != r - l && r == l + 1) {
                output.push_back(to_string(nums[l]));
                l++;
                r++;
            }
            else if (long(nums[r]) - long(nums[l]) != r - l) {
                output.push_back(to_string(nums[l]) + "->" + to_string(nums[r - 1]));
                l = r;
                r = l + 1;
            }
            else {
                r++;
            }
            if (r == nums.size()) {
                if (long(nums[r-1]) - long(nums[l]) != r - l && r == l + 1) {
                output.push_back(to_string(nums[l]));
                }
                else if (nums[r-1] - nums[l] != r - l) {
                output.push_back(to_string(nums[l]) + "->" + to_string(nums[r - 1]));
                }
            break;
            }
        }
        return output;
    }
};