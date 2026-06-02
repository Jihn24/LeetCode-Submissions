// 1897. Minimum Number of Flips to Make the Binary String Alternating
// You are given a binary string s. You can perform two types of operations on the string any number of times:
// 1. Type-1: Remove the character at the start of the string s and append it to the end of the string.
// 2. Type-2: Pick any character in s and flip its value, if it is '0' convert it to '1' and vice-versa.
// Return the minimum number of type-2 operations you need to perform such that s becomes alternating. 
// The string is called alternating if no two adjacent characters are equal. For example, the string "010" 
// is alternating, while the string "0100" is not.

class Solution {
    public int minFlips(String s) {
        int missZero = 0;
        int missOne = 0;    
        int current = 0; 
        int n = s.length();
        int output = n; 
        char[] doubleS = (s + s).toCharArray();
        for (int i = 0; i < doubleS.length; i++) {
            // Pattern 01010...
            current = doubleS[i] - '0';
            if (current == i % 2) missOne++;            
            else missZero++;
            if (i >= n) {
                if (current == (i - n) % 2) missOne--;
                else missZero--;
            }
            if ( i >= n - 1) {
                output = Math.min(output, Math.min(missOne, missZero));
            }
        }
        return output;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.minFlips("111000"));
    }
}
