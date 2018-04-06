using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            // TalkToMe();

            // book.NameChanged += OnNameChanged;  // can do with = new NameChangedDelegate(OnNameChanged); or this way 

            // book.Name = "Scott's Grade Book";
            // book.Name = "Grade Book";

            //book.Name = "Test Book";
            // book.Name = null; // to test an exception situation

            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);



            /* in the example below, the instructor was showing that book2 gets the ADDRESS of book, and therefore whatever edits one of the those edits the other
             * 
            GradeTracker book2 = book; 
            book2.AddGrade(75);
            */
        }

        private static void TalkToMe()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            Console.WriteLine("What is your name, user?");
            String myName = Console.ReadLine();

            synth.Speak("Hello " + myName + " , this is the grade book program");
        }

        private static IGradeTracker CreateGradeBook()
        {

            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))  // did CTRL + . over File to tell it to use system.io and we use "using" to do proper cleanup of the object
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong while getting the name!");
                Console.WriteLine(ex.Message);
            }
        }


        /*
        static void OnNameChanged(object sender, NameChangedEventArgs args)   // part of the delegate example from the course
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
        */


        /*
        static void WriteResult(string description, int result) // showing some examples of method overloading
        {
            Console.WriteLine(description + ": " + result);
        }
        */

        static void WriteResult(string description, string result) // showing some examples of method overloading
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, float result) // showing some examples of method overloading
        {
            Console.WriteLine(description + " (float): " + result);
        }
    }
}
