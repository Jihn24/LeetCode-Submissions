// 1711. Count Good Meals
// A good meal is a meal that contains exactly two different food items with a sum of deliciousness equal to a power of two. 
// You can pick any two different foods to make a good meal. Given an array of integers deliciousness where deliciousness[i] 
// is the deliciousness of the ith item of food, return the number of different good meals you can make from this list 
// modulo 10^9 + 7. Note that items with different indices are considered different even if they have the same deliciousness value.

#include <vector>
#include <unordered_map>

class Solution {
public:
    int countPairs(vector<int>& deliciousness) {
        long count = 0;        
        int MOD = 1000000007;
        unordered_map<int, int> freq;

        for (int d : deliciousness) {
            int power = 1;
            while (power <= 1 << 21) {
                int value = power - d;
                if (freq.contains(value)) {
                    count += freq[value];
                }

                power <<= 1;
            }
            freq[d]++;
        }

        return count % MOD;
    }
};