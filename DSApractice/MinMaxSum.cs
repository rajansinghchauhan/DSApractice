using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApractice
{
    public class MinMaxSum
    {
        public void miniMaxSum(List<long> arr)
        {
            long minumum = 0;
            long maximum = 0;
            List<long> listSum = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                // Sum all elements except the one at index i
                long sum = arr.Where((val, idx) => idx != i).Sum();
                listSum.Add(sum);
            }
            Console.Write(minumum = listSum.Min());
            Console.Write(" ");
            Console.Write(maximum = listSum.Max());
        }
    }
}
