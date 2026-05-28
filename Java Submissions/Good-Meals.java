// 1711. Count Good Meals
// A good meal is a meal that contains exactly two different food items with a sum of deliciousness equal to a power of two. 
// You can pick any two different foods to make a good meal. Given an array of integers deliciousness where deliciousness[i] 
// is the deliciousness of the ith item of food, return the number of different good meals you can make from this list 
// modulo 10^9 + 7. Note that items with different indices are considered different even if they have the same deliciousness value.

import java.util.HashMap;
import java.util.Map;

class Solution {
    public int countPairs(int[] deliciousness) {
        int count = 0;        
        int MOD = 1000000007;
        Map<Integer, Integer> freq = new HashMap<>();

        for (int d : deliciousness) {
            int power = 1;
            while (power <= 1 << 21) {
                int value = power - d;
                if (freq.containsKey(value)) {
                    count = (count + freq.get(value)) % MOD;
                }

                power <<= 1;
            }

            if (freq.containsKey(d)) {
                freq.put(d, freq.get(d) + 1);
            }
            else {
                freq.put(d, 1);
            }
        }

        return count;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.countPairs(new int[]{1,3,5,7,9})); // 4
    }
}