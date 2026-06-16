// 2285. Maximum Total Importance of Roads
// There is a country of n cities numbered from 0 to n - 1. You are given a 2D integer array roads where roads[i] = [ai, bi] 
// indicates that there is a bidirectional road connecting cities ai and bi. The importance of a road is the sum of the values 
// of the two cities it connects. The value of a city is the number of roads that are connected to it. Return the maximum total 
// importance of all roads possible after assigning the values to the cities optimally.

import java.util.Arrays;

class Solution {
    public long maximumImportance(int n, int[][] roads) {
        long output = 0;
        int[] cities = new int[n];

        // Loop through roads counting each occurance of each city, assign value to list
        for (var road : roads) {
            cities[road[0]]++;
            cities[road[1]]++;
        }

        // Order the cities and then assign values 1-n
        Arrays.sort(cities);

        // Loop through each road and sum the importance using the array
        for (int i = 0; i < n; i++) {
            output += (long)cities[i] * (i + 1);
        }        
   
        return output;    
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        int n = 5;
        int[][] roads = {{0,1},{0,2},{1,2},{1,3},{2,4}};
        long result = solution.maximumImportance(n, roads);
        System.out.println(result); // Output: 43
    }
}
