/* ---- CODE SNIPPET 1 ----

    int height = 13;
    if (height <= 12)
        Console.WriteLine("Low bridge: ");
        Console.WriteLine("proceed with caution");

    - Though it is functionally correct, for the result to print out nothing 
    since the height is higher than 12, we can add brackets.

*/

using System;

public class Score 
{
    public static void Main(string[] args) 
    {
        int height = 13;
        if (height <= 12)
            { 
                Console.WriteLine("Low bridge: ");
                Console.WriteLine("proceed with caution.");
            }
    }
}


/* ---- CODE SNIPPET 2 ----

    int sum = 21;
    if ( sum != 20 )
        Console.WriteLine ("You win ");
    else
        Console.WriteLine ("You lose ");
        Console.WriteLine ("the prize.");

    - This is correct.

*/

int sum = 21;
if ( sum != 20 )
    Console.WriteLine ("You win ");
else
    Console.WriteLine ("You lose ");
    Console.WriteLine ("the prize.");


/* ---- CODE SNIPPET 3 ----

    int sum = 7;
    if ( sum > 20 ) {
        Console.WriteLine ("You win ");
    } else {
        Console.WriteLine ("You lose ");
    }
        Console.WriteLine ("the prize.");

    - This is correct.

*/

int sum = 7;
if ( sum > 20 ) {
    Console.WriteLine ("You win ");
} else {
    Console.WriteLine ("You lose ");
}
    Console.WriteLine ("the prize.");