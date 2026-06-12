// 2231. Largest Number After Digit Swaps by Parity
// You are given a positive integer num. You may swap any two digits of num that have the same parity (i.e. both odd digits or both even digits).
// Return the largest possible value of num after any number of swaps.

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Solution {
    public int largestInteger(int num) {
        String number = String.valueOf(num);
        StringBuilder output = new StringBuilder();
        List<Integer> evens = new ArrayList<>();
        List<Integer> odds = new ArrayList<>();
        Boolean[] parity = new Boolean[number.length()];
        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 0; i < number.length(); i++) {
            if (number.charAt(i) % 2 == 0) {
                parity[i] = true;
                evens.add(number.charAt(i) - '0');
                evenIndex++;
            }
            else {
                parity[i] = false;
                odds.add(number.charAt(i) - '0');
                oddIndex++;
            }
        }    

        Collections.sort(odds);
        Collections.sort(evens);

        for (int i = 0; i < number.length(); i++) {
            if (parity[i]) {
                output.append(evens.get(evenIndex - 1));
                evenIndex--;
            }
            else {
                output.append(odds.get(oddIndex - 1));
                oddIndex--;
            }
        }

        return Integer.parseInt(output.toString());
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.largestInteger(1234));
    }
}