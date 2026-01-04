using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class BirthdayCandel
    {
        public int birthdayCakeCandles(List<int> candles)
        {
            int maxValue = candles.Max();
            return  candles.Where(x => x == maxValue).ToList().Count;
        }
    }
}
