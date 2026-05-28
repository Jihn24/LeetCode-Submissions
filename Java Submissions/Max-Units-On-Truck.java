// 1710. Maximum Units on a Truck
// You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:
//     numberOfBoxesi is the number of boxes of type i.
//     numberOfUnitsPerBoxi is the number of units in each box of the type i.
// You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. 
// You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.
// Return the maximum total number of units that can be put on the truck.

import java.util.Arrays;

class Solution {
    public int maximumUnits(int[][] boxTypes, int truckSize) {
        int maximum = 0;
        
        Arrays.sort(boxTypes,(a,b) -> b[1] - a[1]);

        for (var box : boxTypes) {
            var boxCount = box[0];
            var unitsPerBox = box[1];

            var boxesToTake = Math.min(truckSize, boxCount);

            maximum += boxesToTake * unitsPerBox;
            truckSize -= boxesToTake;

            if (truckSize == 0) break;
        }
        return maximum;
    }

    public static void main(String[] args) {
        var solution = new Solution();
        System.out.println(solution.maximumUnits(new int[][]{{1, 3}, {2, 2}, {3, 1}}, 4));
        System.out.println(solution.maximumUnits(new int[][]{{5, 10}, {2, 5}, {4, 7}, {3, 9}}, 10));
    }
}
