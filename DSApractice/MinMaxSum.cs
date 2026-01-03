using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApractice
{
    public class MinMaxSum
    {
        public void miniMaxSum(List<int> arr)
        {
            int minumum = 0;
            int maximum = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                minumum = minumum + arr[i];
            }
            for (int i = arr.Count - 1; i > 1; i--)
            {
                maximum = minumum + arr[i];
            }
            Console.Write(minumum);
            Console.Write(" ");
            Console.Write(maximum);
        }
    }
}
