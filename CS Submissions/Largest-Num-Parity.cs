// 2231. Largest Number After Digit Swaps by Parity
// You are given a positive integer num. You may swap any two digits of num that have the same parity (i.e. both odd digits or both even digits).
// Return the largest possible value of num after any number of swaps.

namespace Largest_Num_Parity {
    public class Program {
        public static void Main(string[] args) {
            Solution solution = new Solution();
            Console.WriteLine(solution.LargestInteger(1234));
        }
    }

    public class Solution {
        public int LargestInteger(int num) {
            string number = Convert.ToString(num);
            Console.WriteLine(number);
            string output = "";
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            bool[] parity = new bool[number.Length];
            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < number.Length; i++) {
                if (number[i] % 2 == 0) {
                    parity[i] = true;
                    evens.Add(number[i] - '0');
                    evenIndex++;
                }
                else {
                    parity[i] = false;
                    odds.Add(number[i] - '0');
                    oddIndex++;
                }
            }    

            odds.Sort();
            evens.Sort();

            for (int i = 0; i < number.Length; i++) {
                if (parity[i]) {
                    output += Convert.ToString(evens[evenIndex - 1]);
                    evenIndex--;
                }
                else {
                    output += Convert.ToString(odds[oddIndex - 1]);
                    oddIndex--;
                }
            }

            return Convert.ToInt32(output);
        }
    }
}