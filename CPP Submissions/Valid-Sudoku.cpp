// 36. Valid Sudoku
// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
// Each row must contain the digits 1-9 without repetition.
// Each column must contain the digits 1-9 without repetition.
// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition. 

#include <vector>
#include <algorithm>
using namespace std;

class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        bool rows[9][9];
        bool columns[9][9];
        bool boxes[9][9];
        int number = 0;
        int boxIndex = 0;
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] != '.') {
                    number = board[i][j] - '1';
                    boxIndex = (i / 3) * 3 + (j / 3);

                    if (rows[i][number] || columns[j][number] || boxes[boxIndex][number]) return false;

                    rows[i][number] = columns[j][number] = boxes[boxIndex][number] = true;
                }
            }
        }
        return true;
    }
};