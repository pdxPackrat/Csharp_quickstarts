using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            { 
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }


        static void LoopsTest()
        {
            // LoopsTest stuff

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello world! The index is {index}");

            }

        }

        static void Exercise2_Test()
        {
            // Goal: find the sum of all integers 1 through 20 that are divisible by 3

            int index;
            int divisor = 3;
            int limit = 20;
            int sum = 0;

            for (index = 1; index < limit; index++)
            {
                if (index % divisor == 0)
                {
                    Console.WriteLine($"{index} is divisible by {divisor}");
                    sum = sum + index;
                    Console.WriteLine($"  Current Sum is: {sum}");

                }
            }
        }

        static void Main(string[] args)
        {
            // ExploreIf();

            // LoopsTest();

            Exercise2_Test();
        }
    }
}
