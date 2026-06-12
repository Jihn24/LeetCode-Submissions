// 2231. Largest Number After Digit Swaps by Parity
// You are given a positive integer num. You may swap any two digits of num that have the same parity (i.e. both odd digits or both even digits).
// Return the largest possible value of num after any number of swaps.

class Solution {
public:
    int largestInteger(int num) {
        string number = to_string(num);
        string output = "";
        vector<int> evens;
        vector<int> odds;
        vector<bool> parity(number.length()) ;
        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 0; i < number.length(); i++) {
            if (number[i] % 2 == 0) {
                parity[i] = true;
                evens.push_back(number[i] - '0');
                evenIndex++;
            }
            else {
                parity[i] = false;
                odds.push_back(number[i] - '0');
                oddIndex++;
            }
        }    

        sort(odds.begin(), odds.end());
        sort(evens.begin(), evens.end());

        for (int i = 0; i < number.length(); i++) {
            if (parity[i]) {
                output += to_string(evens[evenIndex - 1]);
                evenIndex--;
            }
            else {
                output += to_string(odds[oddIndex - 1]);
                oddIndex--;
            }
        }

        return stoi(output);
    }
};