using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Grading
    {
        public List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    // No rounding if grade is below passing threshold
                    result.Add(grade);
                }
                else
                {
                    // Find next multiple of 5
                    int nextMultipleOf5 = ((grade / 5) + 1) * 5;

                    if (nextMultipleOf5 - grade < 3)
                    {
                        result.Add(nextMultipleOf5); // Round up
                    }
                    else
                    {
                        result.Add(grade); // Keep original
                    }
                }
            }

            return result;
        }
    }
}

