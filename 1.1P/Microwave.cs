using System;

public class Microwave
{
    public static void Main()
    {
        Console.WriteLine("Microwave Program");

        // The program asks the user for the number of items to be reheated
        Console.Write("Enter the number of items: ");
        int numberOfItems = int.Parse(Console.ReadLine());

        // The program asks for how long the user wishes to heat the items
        Console.Write("Enter the single-item heating time (in seconds): ");
        double singleItemHeatingTime = double.Parse(Console.ReadLine());

        double recommendedHeatingTime = CalculateRecommendedHeatingTime(numberOfItems, singleItemHeatingTime);

        // The program prints out the recommended time
        Console.WriteLine($"Recommended Heating Time: {recommendedHeatingTime} seconds");
    }


// Formulas for the program to calculate the recommended heating time
    public static double CalculateRecommendedHeatingTime(int numberOfItems, double singleItemHeatingTime)
    {
        if (numberOfItems == 1)
        {
            return singleItemHeatingTime;
        }
        else if (numberOfItems == 2)
        {
            // Adding 50% to the heating time for two items
            return singleItemHeatingTime + (singleItemHeatingTime / 2);
        }
        else if (numberOfItems == 3)
        {
            // Doubling the heating time for three items
            return singleItemHeatingTime * 2;
        }
        else
        {
            // Since more than three items are not recommended, return -1 to indicate an invalid input
            return -1;
        }
    }
}
