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

class Solution {
    public String RLE(String s) {
        StringBuilder sb = new StringBuilder("");
        char[] sArray = s.toCharArray();
        int r = 0;
        int l = 0;
        while (l + r < s.length()) {
            if (sArray[l] == sArray[l + r]) {
                r++;
            }
            else {
                sb.append(r);
                sb.append(sArray[l]);
                l += r;
                r = 0;
            }
            if (l + r >= s.length()) {
                sb.append(r);
                sb.append(sArray[l]);
            }
        }
        return sb.toString();
    }
    public String countAndSay(int n) {
        if (n == 1) return "1";
        String output = "1";
        for (int i = 0; i < n - 1; i++) {
            output = RLE(output);
        }
        return output;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.countAndSay(4)); // "1211"
    }
}