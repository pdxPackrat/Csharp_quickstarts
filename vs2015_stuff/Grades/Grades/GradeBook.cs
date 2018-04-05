using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
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

        /*
        public string Name
        {
            get; set; // auto-implementer that turns this from a field to a property
        }
        */

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChanged(_name, value);
                    }

                    _name = value; // value is an automatic parameter passed in as part of the set and this code prevents null assignment
                }
            }
        }

        public NameChangedDelegate NameChanged;  // from NameChangedDelegate.cs

        private string _name;
        private List<float> grades;
    }
}
