// 1711. Count Good Meals
// A good meal is a meal that contains exactly two different food items with a sum of deliciousness equal to a power of two. 
// You can pick any two different foods to make a good meal. Given an array of integers deliciousness where deliciousness[i] 
// is the deliciousness of the ith item of food, return the number of different good meals you can make from this list 
// modulo 10^9 + 7. Note that items with different indices are considered different even if they have the same deliciousness value.

namespace GoodMeals {
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.CountPairs(new int[] { 1, 3, 5, 7, 9 });
            Console.WriteLine(result);
        }
    }

    class Solution {
        public int CountPairs(int[] deliciousness) {
            int count = 0;        
            int MOD = 1000000007;
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach(int d in deliciousness) {
                int power = 1;
                while (power <= 1 << 21) {
                    int value = power - d;
                    if (freq.ContainsKey(value)) {
                        count = (count + freq[value]) % MOD;
                    }

                    power = power << 1;
                }

                if (freq.ContainsKey(d)) {
                    freq[d]++;
                }
                else {
                    freq[d] = 1;
                }
            }

            return count;
        }
    }
}