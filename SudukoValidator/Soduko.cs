namespace SudukoValidator;

public class Soduko
{
    public class Solution
    {
        private char[][] board;

        public Solution()
        {
            board = new char[9][];
            foreach (Char[] row in board)
            {
                row[0] = '9';
            }
        }

        public bool IsValidSudoku(Char[][] board)
        {
            return false;
        }
    }
    
}