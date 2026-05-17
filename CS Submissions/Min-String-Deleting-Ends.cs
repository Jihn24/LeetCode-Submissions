// 1750. Minimum Length of String After Deleting Similar Ends
// You are given a string s consisting only of characters 'a', 'b', and 'c'. You can delete the characters 
// in the string by performing the following steps any number of times:
// 1. Pick a non-empty prefix from the string s where all the characters in the prefix are the same.
// 2. Pick a non-empty suffix from the string s where all the characters in the suffix are the same.
// 3. The prefix and the suffix should not intersect at any index. 
// 4. The characters from the prefix and suffix must be the same.
// 5. Delete both the prefix and the suffix from the string s.
// Return the minimum length of s after performing the above operation any number of times (possibly zero times). 

var solution = new Solution();
var result = solution.MinimumLength("aabccabba");
Console.WriteLine(result);

public class Solution {
    public int MinimumLength(string s) {
        int l = 0;
        int r = s.Length - 1;
        char letter;
        if (r == -1) {
            return 0;
        } 
        else if (r == 0) {
            return 1;
        }
        while (l < r) {
            if (s[l] == s[r]) {
                letter = s[l];
                if (r == 1) {
                    return 0;
                }
                while (s[r] == letter) {
                    r--;
                    if (r == 0) {
                        return 0;
                    }
                }
                while (s[l] == letter) {
                    l++;
                }  
                           
            }
            else {
                break;
            }
        }
        if (r - l < 0) {
            return 0;
        }
        return r - l + 1;
    }
}