﻿using System;
using System.Speech.Synthesis;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            Console.WriteLine("Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");

            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            synth.Speak("Hello " + name + ", it is nice to meet you!");

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");

            }
            else
            {
                Console.WriteLine("You need more sleep");
            }


            // Console.WriteLine("Hello, " + args[0]);

            /* Try/Catch block to catch if we get a runtime error with no args passed
            
            try
            {
                Console.WriteLine("Hello, " + args[0]);
            }
            catch
            {
                Console.WriteLine("Hello, World!");
            }

            */
        }
    }
}
