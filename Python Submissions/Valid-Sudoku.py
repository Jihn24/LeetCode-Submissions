# 36. Valid Sudoku
# Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
# Each row must contain the digits 1-9 without repetition.
# Each column must contain the digits 1-9 without repetition.
# Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

class Solution(object):
    def isValidSudoku(self, board):
        """
        :type board: List[List[str]]
        :rtype: bool
        """
        rows = [set() for x in range (9)]
        columns = [set() for x in range (9)] 
        boxes = [set() for x in range (9)] 
        for i in range(9):
            for j in range (9):
                if (board[i][j] != '.'):
                    number = int(board[i][j]) - 1                    
                    boxIndex = (i // 3) * 3 + (j // 3)
                    if (number in rows[i] or number in columns[j] or number in boxes[boxIndex]):
                        return False

                    rows[i].add(number)
                    columns[j].add(number)
                    boxes[boxIndex].add(number)
        return True
        
solution = Solution()
print(solution.isValidSudoku([["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],
                              [".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],
                              ["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],
                              [".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],
                              [".",".",".",".","8",".",".","7","9"]])) # True   