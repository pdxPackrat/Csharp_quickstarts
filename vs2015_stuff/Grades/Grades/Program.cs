using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();

            //Console.WriteLine("What is your name, user?");
            //String myName = Console.ReadLine();

            //synth.Speak("Hello " + myName +" , this is the grade book program");

            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;  // can do with = new NameChangedDelegate(OnNameChanged); or this way 

            book.Name = "Scott's Grade Book";
            book.Name = "Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);



            /* in the example below, the instructor was showing that book2 gets the ADDRESS of book, and therefore whatever edits one of the those edits the other
             * 
            GradeBook book2 = book; 
            book2.AddGrade(75);
            */
        }

        
        static void OnNameChanged(object sender, NameChangedEventArgs args)   // part of the delegate example from the course
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }


        static void WriteResult(string description, int result) // showing some examples of method overloading
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result) // showing some examples of method overloading
        {
            Console.WriteLine(description + " (float): " + result);
        }
    }
}
