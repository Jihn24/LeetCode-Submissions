// 1011. Capacity To Ship Packages Within D Days
// A conveyor belt has packages that must be shipped from one port to another within D days. 
// The i-th package on the conveyor belt has a weight of weights[i]. Each day, we load the ship 
// with packages on the conveyor belt (in the order given by weights). We may not load more weight 
// than the maximum weight capacity of the ship. Return the least weight capacity of the ship that 
// will result in all the packages on the conveyor belt being shipped within D days.

namespace CapacityInDays {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();
            var result = solution.ShipWithinDays(new int[] {1,2,3,4,5,6,7,8,9,10}, 5);
            Console.WriteLine(result); // 15
        }
    }

    // Second attempt, cleaner code runs faster.
    public class Solution {
        public int ShipWithinDays(int[] weights, int days) {
            int minViable = weights[0];
            int maxViable = 0;
            foreach (int weight in weights) {
                maxViable += weight;
                minViable = Math.Max(minViable, weight);
            }
        
            int currDays = 1;
            if (days == 1) return maxViable;
            int currMinWeight = (minViable + maxViable) / 2;
            int currTestWeight = 0;
            loopStart:
            while (minViable < maxViable) {
                currDays = 1;
                currTestWeight = 0;
                foreach (int weight in weights) {
                    if (currTestWeight + weight <= currMinWeight) {
                        currTestWeight += weight;
                    }
                    else {
                        currDays++;
                        currTestWeight = weight;
                        if (currDays > days) {
                            minViable = currMinWeight + 1;
                            currMinWeight = (minViable + maxViable) / 2;
                            goto loopStart; 
                        }
                    }
                }
                maxViable = currMinWeight;
                currMinWeight = (minViable + maxViable) / 2;
            }   
            return minViable;        
        }
    }
}

// First attempt, brute force approach that checks every possible weight capacity starting from the maximum weight in the array. 
// This approach is too slow and will time out on larger inputs.

// public class Solution {
//     public int ShipWithinDays(int[] weights, int days) {
//         // The minimum viable weight is the maximum weight in the array, since we can't split packages.
//         // The maximum viable weight is the sum of all weights, since we could ship everything in one day.
//         int minViable = weights.Max();
//         int maxViable = 0;
//         foreach (int weight in weights) {
//             maxViable += weight;
//         }
    
//         int currDays = 1;
//         if (days == 1) return maxViable;

//         // We can use binary search to find the minimum viable weight. We test the middle weight, 
//         // and if it takes more than D days to ship all packages, we know we need a heavier ship. 
//         // If it takes less than or equal to D days, we can try a lighter ship.
//         int currMinWeight = (minViable + maxViable) / 2;
//         int currTestWeight = 0;
//         loopStart:
//         while (minViable < maxViable) {
//             currDays = 1;
//             currTestWeight = 0;
//             for (int i = 0; i < weights.Length; i++) {
//                 if (currTestWeight + weights[i] <= currMinWeight) {
//                     currTestWeight += weights[i];
//                 }
//                 else {
//                     currDays++;
//                     currTestWeight = weights[i];
//                     if (currDays > days) {
//                         minViable = currMinWeight + 1;                        
//                         // The minViable is now one more than the current minimum weight, since we know this weight is not viable.
//                         // The current weight is the mean of the new minViable and the maxViable.
//                         currMinWeight = (minViable + maxViable) / 2;
//                         // We can skip the rest of the loop since we already know this weight is not viable.
//                         goto loopStart; 
//                     }
//                 }
//             }
//             // If we get here, it means the current weight is viable, so we can try a lighter ship.
//             maxViable = currMinWeight;
//             currMinWeight = (minViable + maxViable) / 2;
//         }   
//         return minViable;        
//     }
// }