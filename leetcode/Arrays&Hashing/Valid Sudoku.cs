using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays_Hashing
{
    internal class Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var sudo = new HashSet<string>();
            for (int i = 0; i < board[0].Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }
                    if (!sudo.Add($"{board[i][j]} in row{i}") ||
                        !sudo.Add($"{board[i][j]} in column{j}") ||
                        !sudo.Add($"{board[i][j]} in subBox{i / 3},{j / 3}"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
