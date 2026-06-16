// 2285. Maximum Total Importance of Roads
// There is a country of n cities numbered from 0 to n - 1. You are given a 2D integer array roads where roads[i] = [ai, bi] 
// indicates that there is a bidirectional road connecting cities ai and bi. The importance of a road is the sum of the values 
// of the two cities it connects. The value of a city is the number of roads that are connected to it. Return the maximum total 
// importance of all roads possible after assigning the values to the cities optimally.

class Solution {
public:
    long long maximumImportance(int n, vector<vector<int>>& roads) {
        long long output = 0;
        long long importance = n;
        vector<int> cities(n, 0);

        // Loop through roads counting each occurance of each city, assign value to list
        for (vector<int>& road : roads) {
            cities[road[0]]++;
            cities[road[1]]++;
        }

        // Order the cities and then assign values 1-n
        sort(cities.begin(), cities.end(), greater<int>());

        // Loop through each road and sum the importance using the array
        for (int i : cities) {
            if (i == 0) {
                break;
            }
            output += i * importance--;
        }        
   
        return output;     
    }
};