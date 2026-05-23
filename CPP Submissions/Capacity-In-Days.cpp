// 1011. Capacity To Ship Packages Within D Days
// A conveyor belt has packages that must be shipped from one port to another within D days. 
// The i-th package on the conveyor belt has a weight of weights[i]. Each day, we load the ship 
// with packages on the conveyor belt (in the order given by weights). We may not load more weight 
// than the maximum weight capacity of the ship. Return the least weight capacity of the ship that 
// will result in all the packages on the conveyor belt being shipped within D days.

class Solution {
public:
    int shipWithinDays(vector<int>& weights, int days) {
        int minViable = weights[0];
        int maxViable = 0;
        for (int weight : weights) {
            maxViable += weight;
            minViable = max(minViable, weight);
        }
    
        int currDays = 1;
        if (days == 1) return maxViable;
        int currMinWeight = (minViable + maxViable) / 2;
        int currTestWeight = 0;
        loopStart:
        while (minViable < maxViable) {
            currDays = 1;
            currTestWeight = 0;
            for (int weight : weights) {
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
};