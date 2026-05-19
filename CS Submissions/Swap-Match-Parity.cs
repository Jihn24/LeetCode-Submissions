// 2231. Largest Number After Digit Swaps by Parity
// You are given a positive integer num. You may swap any two digits of num that have the same parity 
// (i.e. both odd digits or both even digits).
// Return the largest possible value of num after any number of swaps.

namespace SwapMatchParity {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.LargestInteger(1234); 
            Console.WriteLine(result);
        }
    }

    class Solution {
        public int LargestInteger(int num) {
            string number = Convert.ToString(num);
            string output = "";
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            bool[] parity = new bool[number.Length];

            for (int i = 0; i < number.Length; i++) {
                if (number[i] % 2 == 0) {
                    parity[i] = true;
                    evens.Add(number[i] - '0');
                }
                else {
                    parity[i] = false;
                    odds.Add(number[i] - '0');
                }
            }    

            int evenIndex = evens.Count - 1;
            int oddIndex = odds.Count - 1;
            odds.Sort();
            evens.Sort();

            for (int i = 0; i < number.Length; i++) {
                if (parity[i]) {
                    output += Convert.ToString(evens[evenIndex]);
                    evenIndex--;
                }
                else {
                    output += Convert.ToString(odds[oddIndex]);
                    oddIndex--;
                }
            }

            return Convert.ToInt32(output);
        }
    }
}