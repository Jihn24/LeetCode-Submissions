// 1837. Sum of Digits in Base K
// Given an integer n (in base 10) and a base k, return the sum of the digits of n after converting n from base 10 to base k.
// After converting, each digit should be interpreted as a base 10 number, and the sum should be returned in base 10.

namespace SumBase {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.SumBase(34, 6);
            Console.WriteLine(result);
        }
    }

    public class Solution {
        public int SumBase(int n, int k) {
            int output = 0;
            do {
                output += n % k;
                n /= k; 
            } while (n != 0);
            return output;
        }
    }
}