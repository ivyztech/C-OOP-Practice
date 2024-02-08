using System;

namespace IfStatement
{
    class IfStatement
    {
        static void Main(string[] args) //Main method
        {
            Console.WriteLine("Enter a number between 1 and 9:"); //Starting prompt
            string input = Console.ReadLine(); //Getting user input and saving it
            
            /* try statement defines the block of code below to be tested for errors 
            (non integer, out of the 1-9 range) while it is being executed */
            try
            {
                int number = Convert.ToInt32(input); //converts user input to integer value

                //writes the specific output for each number
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
                } //program outputs error message when user enter a number not between specified range
            }

            catch(FormatException) //catch statement outputs error message when user inputs wrong values
            {
                Console.WriteLine("Error: Invalid input format. Please enter a vaild integer.");
            }
        }
    }
}         

        

