using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradeBook : GradeBook
    {
        public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");

            float lowest = float.MaxValue;

            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest); // risky because if there is only one grade it will cause problems

            return base.ComputeStatistics();
        }
    }
}
