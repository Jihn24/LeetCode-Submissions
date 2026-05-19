// 38. Count and Say
// The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
// countAndSay(1) = "1"
// countAndSay(n) is the way you would "say" the digit string from countAndSay(n-1), which is then converted into a different 
// digit string. To determine how you "say" a digit string, split it into the minimal number of groups so that each group is a 
// contiguous section all of the same character. Then for each group, say the number of characters, then say the character. 
// To convert the saying into a digit string, replace the counts with a number and concatenate every saying. 
// For example, to compress the string "3322251" we replace "33" with "23", replace "222" with "32", 
// replace "5" with "15" and replace "1" with "11". Thus the compressed string becomes "23321511".
// Given a positive integer n, return the nth term of the count-and-say sequence.

using System.Text;
namespace CountAndSay {
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.CountAndSay(5);
            Console.WriteLine(result);
        }
    }
    class Solution {
        public string RLE(string s) {
            StringBuilder sb = new StringBuilder("");
            int r = 0;
            int l = 0;
            while (l + r < s.Length) {
                if (s[l] == s[l + r]) {
                    r++;
                }
                else {
                    sb.Append(r);
                    sb.Append(s[l]);
                    l += r;
                    r = 0;
                }
                if (l + r >= s.Length) {
                    sb.Append(r);
                    sb.Append(s[l]);
                }
            }
            return sb.ToString();
        }
        public string CountAndSay(int n) {
            if (n == 1) return "1";
            string output = "1";
            for (int i = 0; i < n - 1; i++) {
                output = RLE(output);
            }
            return output;
        }
    }
}