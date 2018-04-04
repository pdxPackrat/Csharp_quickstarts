using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>(); 
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            

            
            float sum = 0f;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);  // computes which of the two numbers is higher and returns that to HighestGrade
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);  // computes which of the two numbers is lower and returns that to LowestGrade

                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;  // might need try and catch here

            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}
