// 36. Valid Sudoku
// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
// Each row must contain the digits 1-9 without repetition.
// Each column must contain the digits 1-9 without repetition.
// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

var solution = new Solution();
var result = solution.IsValidSudoku(new char[][] {
    new char[] {'5','3','.','.','7','.','.','.','.'},
    new char[] {'6','.','.','1','9','5','.','.','.'},
    new char[] {'.','9','8','.','.','.','.','6','.'},
    new char[] {'8','.','.','.','6','.','.','.','3'},
    new char[] {'4','.','.','8','.','3','.','.','1'},
    new char[] {'7','.','.','.','2','.','.','.','6'},
    new char[] {'.','6','.','.','.','.','2','8','.'},
    new char[] {'.','.','.','4','1','9','.','.','5'},
    new char[] {'.','.','.','.','8','.','.','7','9'}
});
Console.WriteLine(result);

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rows = new bool[9,9];
        bool[,] columns = new bool[9,9];
        bool[,] boxes = new bool[9,9];
        int number = 0;
        int boxIndex = 0;
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] != '.') {
                    number = board[i][j] - '1';
                    boxIndex = (i / 3) * 3 + (j / 3);

                    if (rows[i, number] || columns[j, number] || boxes[boxIndex, number]) return false;

                    rows[i, number] = columns[j, number] = boxes[boxIndex, number] = true;
                }
            }
        }
        return true;
    }
}