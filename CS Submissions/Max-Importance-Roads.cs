// 2285. Maximum Total Importance of Roads
// There is a country of n cities numbered from 0 to n - 1. You are given a 2D integer array roads where roads[i] = [ai, bi] 
// indicates that there is a bidirectional road connecting cities ai and bi. The importance of a road is the sum of the values 
// of the two cities it connects. The value of a city is the number of roads that are connected to it. Return the maximum total 
// importance of all roads possible after assigning the values to the cities optimally.

namespace MaxImportanceRoads {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.MaximumImportance(5, [[0, 1], [0, 2], [1, 2], [1, 3], [2, 3], [2, 4]]);
            Console.WriteLine(result);
        }
    }

    class Solution {
        public long MaximumImportance(int n, int[][] roads) {
            long output = 0;
            Dictionary<int, int> cities = new Dictionary<int, int>(n);

            // Loop through roads counting each occurance of each city, assign value to dict
            foreach (var road in roads) {
                if (cities.ContainsKey(road[0])) {
                    cities[road[0]]++;
                }
                else {
                    cities[road[0]] = 1;
                }
                if (cities.ContainsKey(road[1])) {
                    cities[road[1]]++;
                }
                else {
                    cities[road[1]] = 1;
                }
            }

            // Fill in cities without any roads connected to be 0

            for (int j = 0; j < n; j++) {
                if (!cities.ContainsKey(j)) {
                    cities[j] = 0;
                }
            }

            // Order the cities and then assign values 1-n

            var citiesOrdered = cities.OrderBy(entry => entry.Value).ToList();
            int i = 1;

            foreach (var city in citiesOrdered) {
                cities[city.Key] = i;
                i++;
            }

            // Loop through each road and sum the two cities using the dictionary key value pairs

            foreach (var road in roads) {
                output += cities[road[0]] + cities[road[1]];
            }        
            return output;           
        }
    }
}