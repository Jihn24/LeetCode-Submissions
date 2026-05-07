// There is a street with n * 2 plots, where there are n plots on each side of the street. The plots on each side are numbered from 1 to n. On each plot, a house can be placed.
// Return the number of ways houses can be placed such that no two houses are adjacent to each other on the same side of the street. Since the answer may be very large, return it modulo 109 + 7.
// Note that if a house is placed on the ith plot on one side of the street, a house can also be placed on the ith plot on the other side of the street.

var solution = new Solution();
var result = solution.CountHousePlacements(3);  
Console.WriteLine(result);

public class Solution {
    public int CountHousePlacements(int n) {
        int mod = 1000000007; 
        long prev_2 = 1;
        long prev_1 = 1;
        long current = 2;

        for (int i = 2; i <= n; i++) {
            prev_2 = prev_1;
            prev_1 = current;
            current = (prev_2 + prev_1) % mod;
        }

        return (int)((current * current) % mod);

    }
}

