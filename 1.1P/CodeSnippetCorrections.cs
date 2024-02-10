/* ---- CODE SNIPPET 1 ----

    int number = 50;
    if (number == 50) ; {
        Console.WriteLine("Number is 50") ;
    }

    - Has an unnecessary semi-colon after the if statement
    - Curly brace placement could be better
    - Delete space between statement and ending semi-colon

*/

using System.Collections;

int number = 50;
    if (number == 50)  
    {
        Console.WriteLine("Number is 50") ;
    }


/* ---- CODE SNIPPET 2 ----

    int number = 60;
    if (number >== 50 and number <== 100) {
    Console.WriteLine(“Number is more than or equal to 50 and less than or equal to 100”);
    }

    - Could have been indented better
    - Instead of writing 'and' in the if statement, we have to use the binary conditional logical AND operator (&&)
    - Get rid of the extra = with the conditional logic 

*/

int number = 60;
    if (number >= 50 && number <= 100)
    {
        Console.WriteLine(“Number is more than or equal to 50 and less than or equal to 100”);
    }


/* ---- CODE SNIPPET 3 ----

    public class Score {
    public static void main(String[] args) {
        double score = 40;
        if score > 40{
            Console.WriteLine("You passed the exam!");
    } else score < 40{
        Console.WriteLine("You failed the exam!");
        }
    }
}

    - Added the missing parentheses after the if keyword
    - There is an issue with the main method's capitalisation
    - We have to remove the condition with the else keyword since its condition is already implied

*/

public class Score {
    public static void Main(string[] args) {
        double score = 40;
        if (score > 40)
        {
            Console.WriteLine("You passed the exam!");
        } 
        else 
        {
        Console.WriteLine("You failed the exam!");
        }
    }
}

/* ---- CODE SNIPPET 4 ----

Switch (n) {
    case 1: Console.WriteLine(“The number is 1”);
    case 2: Console.WriteLine (“The number is 2”); break;
    default: Console.WriteLine (“The number is not 1 or 2”);
    break;
}

    - Better identation is needed
    - Each case block should have a break statement

*/

public class CodeSnippet4 {
    public static void Main(string[] args) 
    {
        switch (n)
            {
                case 1:
                    Console.WriteLine("The number is 1");
                    break;
                case 2:
                    Console.WriteLine("The number is 2");
                    break;
                default:
                    Console.WriteLine("The number is not 1 or 2");
                    break;
            }
    }
}

/* ---- CODE SNIPPET 5 ----

switch (n) {
    Case 1: Console.WriteLine (“A”); break;
    case2: Console.WriteLine (“B”); break;
    Default: Console.WriteLine (“C”); break;
    }

    - Better identation is needed as well as proper syntax for each case block
    - Each case block should have a break statement

*/

public class CodeSnippet5 {
    public static void Main(string[] args) 
    {
        switch (n)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }
    }
}








