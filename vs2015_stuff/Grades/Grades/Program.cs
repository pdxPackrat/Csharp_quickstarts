﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Avg: " + stats.AverageGrade);
            Console.WriteLine("Highest: " + stats.HighestGrade);
            Console.WriteLine("Lowest: " + stats.LowestGrade); 

            /* in the example below, the instructor was showing that book2 gets the ADDRESS of book, and therefore whatever edits one of the those edits the other
             * 
            GradeBook book2 = book; 
            book2.AddGrade(75);
            */ 

        }
    }
}
