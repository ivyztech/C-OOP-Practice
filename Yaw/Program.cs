using System;

namespace IfStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 9:");
            string input = Console.ReadLine();
            
            try
            {
                int number = Convert.ToInt32(input);

                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                } 
                else if (number == 4)
                {
                    Console.WriteLine("FOUR");
                } 
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                } 
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }   
                else if (number == 8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }  
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number between 1 and 9.");
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a vaild integer.");
            }
        }
    }
}         

        