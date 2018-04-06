using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics() // adding override to the method to cause it to have precedence in any behavior in the virtual/abstract method of the base class
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
