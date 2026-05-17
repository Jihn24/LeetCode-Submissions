// 1897. Minimum Number of Flips to Make the Binary String Alternating
// You are given a binary string s. You can perform two types of operations on the string any number of times:
// 1. Type-1: Remove the character at the start of the string s and append it to the end of the string.
// 2. Type-2: Pick any character in s and flip its value, if it is '0' convert it to '1' and vice-versa.
// Return the minimum number of type-2 operations you need to perform such that s becomes alternating. 
// The string is called alternating if no two adjacent characters are equal. For example, the string "010" 
// is alternating, while the string "0100" is not.

var solution = new Solution();
var result = solution.MinFlips("111000");
Console.WriteLine(result);

public class Solution {
    public int MinFlips(string s) {
        int missZero = 0;
        int missOne = 0;    
        int current = 0; 
        int n = s.Length;
        int output = n; 
        string doubleS = s + s;
        for (int i = 0; i < doubleS.Length; i++) {
            
            current = (int)Char.GetNumericValue(doubleS[i]);
            if (current == i % 2) missOne++;      // Pattern 01010...      
            else missZero++;                      // Pattern 10101...
            if (i >= n) {
                if (current == (i - n) % 2) missOne--;
                else missZero--;
            }
            if ( i >= n - 1) {
                output = Math.Min(output, Math.Min(missOne, missZero));
            }
        }
        return output;
    }
}