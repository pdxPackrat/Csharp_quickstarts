﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void OutputGrades()
        {
            // trying some new
            GradeBook book = new GradeBook();
            book.Name = "Testing something else";

            book.AddGrade(99);
            book.AddGrade(50);
            book.AddGrade(90);
            book.AddGrade(60);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("C", result.LetterGrade);
        }

        [TestMethod]
        public void ComputeLetterGrade()
        {
            GradeBook book = new GradeBook();
            book.Name = "Testing ComputeLetterGrade()";
            book.AddGrade(85);
            book.AddGrade(97);
            book.AddGrade(80);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("B", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }
    }
}
