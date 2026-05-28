// 1710. Maximum Units on a Truck
// You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:
//     numberOfBoxesi is the number of boxes of type i.
//     numberOfUnitsPerBoxi is the number of units in each box of the type i.
// You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. 
// You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.
// Return the maximum total number of units that can be put on the truck.

namespace Max_Units_On_Truck
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] boxTypes = new int[][] {
                new int[] {1, 3},
                new int[] {2, 2},
                new int[] {3, 1}
            };
            int truckSize = 4;
            Solution solution = new Solution();
            int result = solution.MaximumUnits(boxTypes, truckSize);
            Console.WriteLine(result);
        }
    }
    public class Solution {
        public int MaximumUnits(int[][] boxTypes, int truckSize) {
            int maximum = 0;
            
            Array.Sort(boxTypes,(a,b)=>{
                return b[1].CompareTo(a[1]);
            });

            foreach (var box in boxTypes) {
                var boxCount = box[0];
                var unitsPerBox = box[1];

                var boxesToTake = Math.Min(truckSize, boxCount);

                maximum += boxesToTake * unitsPerBox;
                truckSize -= boxesToTake;

                if (truckSize == 0) break;
            }
            return maximum;
        }
    }
}