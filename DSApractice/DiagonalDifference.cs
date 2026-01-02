using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApractice
{
    public class DiagonalDifference
    {
        public int diagonalDifference(List<List<int>> arr)
        {
            int absoluteDifference = 0;
            int leftToRightDiagonal = 0;
            int rightToLeftDiagonal = 0;
            int counter = 0;
            for (int row = 0; row < arr.Count; row++)
            {
                for (int col = 0; col < arr.Count; col++)
                {
                    if (row == col)
                    {
                        leftToRightDiagonal += arr[row][col];
                    }
                    if (row == arr.Count - col - 1)
                    {
                        rightToLeftDiagonal += arr[row][col];
                    }
                }
            }

            return absoluteDifference = Math.Abs(leftToRightDiagonal - rightToLeftDiagonal);
        }
    }
}
