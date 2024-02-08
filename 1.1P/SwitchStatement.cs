using System;

namespace SwitchStatement
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (as an integer): ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number) //expression is evaluated once
            {
                case 1: //the value of the expression is compared with the values of each case
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default: //this keyword is optional and specifies some code to run if there is not case match
                    Console.WriteLine("Error: You must enter an integer between 1 and 9.");
                    break; //once the program reaches break, it stops the execution of more code and case testing
            }

            Console.ReadLine();
        }
    }
}
