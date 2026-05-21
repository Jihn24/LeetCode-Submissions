// 3043. Find the Length of the Longest Common Prefix of Two Arrays
// You are given two arrays with positive integers arr1 and arr2.
// A prefix of a positive integer is an integer formed by one or more of its digits, starting from its leftmost digit. For example, 123 is a prefix of the integer 12345, while 234 is not.
// A common prefix of two integers a and b is an integer c, such that c is a prefix of both a and b. For example, 5655359 and 56554 have common prefixes 565 and 5655 while 1223 and 43456 do not have a common prefix.
// You need to find the length of the longest common prefix between all pairs of integers (x, y) such that x belongs to arr1 and y belongs to arr2.
// Return the length of the longest common prefix among all pairs. If no common prefix exists among them, return 0.

class Solution {
    public int longestCommonPrefix(int[] arr1, int[] arr2) {
        int output = 0;
        int longest = -1;
        java.util.HashSet<Integer> prefix = new java.util.HashSet<Integer>();

        for (int number1 : arr1) {
            int number = number1;
            if (!prefix.contains(number)){
                while (number > 0){
                    prefix.add(number);
                    number /= 10;
                }
            }
        }
        
        for (int number2 : arr2){
            int number = number2;
            while (number > 0){
                if (prefix.contains(number)){
                    longest = Math.max(longest, number);
                    break;
                }
                number /= 10;
            }
        }
        
        output = longest > 0 ? (String.valueOf(longest).length()) : 0;
        return output;
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.longestCommonPrefix(new int[]{123, 456, 789}, new int[]{12, 45, 78})); // 2 
    }
}
