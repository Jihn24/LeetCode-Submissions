// 5. Longest Palindromic Substring
// Given a string s, return the longest palindromic substring in s.

class Solution {
    public String longestPalindrome(String s) {
        String[] T = ("^#" + String.join("#", s.split("")) + "#$").split("");
        int n = T.length;
        int[] P = new int[n];
        int C = 0; 
        int R = 0;
        int max_len = 0;
        int center_index = 0;

        for (int i = 1; i < n-1; i++) {
            P[i] = (R > i) ? Math.min(R - i, P[2*C - i]) : 0;
            while (T[i + 1 + P[i]].equals(T[i - 1 - P[i]])) {
                P[i]++;
                if (i + P[i] > R) {
                    C = i;
                    R = i + P[i];
                }                
            }
            max_len = Math.max(max_len, P[i]);
            if (max_len == P[i]) {
                center_index = i;
            }
        }
        return s.substring((center_index - max_len) / 2, (center_index + max_len) / 2);
    }
}

public static void main(String[] args) {
    Solution solution = new Solution();
    System.out.println(solution.longestPalindrome("babad")); // "aba" or "bab"
}