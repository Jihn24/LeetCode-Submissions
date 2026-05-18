// 5. Longest Palindromic Substring
// Given a string s, return the longest palindromic substring in s.

#include <string>
#include <vector>
#include <bits/stdc++.h>
using namespace std;

class Solution {
public:
    string longestPalindrome(string s) {
        int max_len = 0;
        int center_index =  0;
        string T = "^";
        for (int i = 0; i < s.length(); i++) {
            T += "#"; 
            T += s[i];
        }
        T += "#$";
        int n = T.length();
        int P[n];
        int C = 0, R = 0;

        for (int i = 1; i < n-1; i++) {
            P[i] = (R > i) ? min(R - i, P[2*C - i]) : 0;
            while (T[i + 1 + P[i]] == T[i - 1 - P[i]]) {
                P[i]++;

                if (i + P[i] > R) {
                    C = i;
                    R = i + P[i];
                }
                max_len = max(max_len, P[i]);
                if (max_len == P[i]) {
                    center_index = i;
                }
            }
        }
        return s.substr((center_index-max_len) / 2, max_len);
    }
};

