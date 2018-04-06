using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>(); 
        }

        public override GradeStatistics ComputeStatistics() // overriding the ComputeStatistics method defined in GradeTracker.cs
        {
            Console.WriteLine("GradeBook:ComputeStatistics");

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

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);

            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        /*
        public string Name
        {
            get; set; // auto-implementer that turns this from a field to a property
        }
        */


        protected List<float> grades;  // changing to protected to allow ThrowAwayGradeBook.cs to have access
    }
}
