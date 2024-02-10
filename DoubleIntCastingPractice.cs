using System;

namespace Practice;

    class Practice
    {
        public static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;

            int intAverage = sum / count;

            Console.WriteLine("Integer Average:" + intAverage);

            double doubleAverage = sum/count;
            Console.WriteLine("Double Average:" + doubleAverage);

            doubleAverage = (double)sum / count;
            Console.WriteLine("Correct Double Average:" + doubleAverage);


        }
    }

