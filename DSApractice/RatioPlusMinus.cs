using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApractice
{
    public class RatioPlusMinus
    {
        public void plusMinus(List<int> arr)
        {
            int arrLength = arr.Count();
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            foreach (int item in arr)
            {
                if (item > 0)
                {
                    positiveCount += 1;
                }
                else if (item < 0)
                {
                    negativeCount += 1;
                }
                else
                {
                    zeroCount += 1;
                }
            }
            var positiveRatio = (double)positiveCount / arrLength;
            var negativeRatio = (double)negativeCount / arrLength;
            var zeroRatio = (double)zeroCount / arrLength;
            Console.WriteLine(positiveRatio.ToString("F6"));
            Console.WriteLine(negativeRatio.ToString("F6"));
            Console.WriteLine(zeroRatio.ToString("F6"));
        }
    }
}
