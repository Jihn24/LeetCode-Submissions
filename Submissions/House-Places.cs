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

