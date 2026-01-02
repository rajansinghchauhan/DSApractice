using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApractice
{
    public class Compare
    {
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            int aliceScore = 0;
            int bobScore = 0;

            if (a.Count == b.Count)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (a[i] > b[i])
                    {
                        aliceScore += 1;
                    }
                    else if (a[i] < b[i])
                    {
                        bobScore += 1;
                    }
                }
                score.Add(aliceScore);
                score.Add(bobScore);
            }
            return score;
        }


    }
}
