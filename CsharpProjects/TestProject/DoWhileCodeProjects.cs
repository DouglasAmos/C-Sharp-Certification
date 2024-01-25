using System;

public class DoWhileStatementsCodeChallenges
{



    public void CodeProject1()
    {

        Console.WriteLine("Please enter a integer between 5 and 10");
        int numericValue = 0;

        do
        {

            bool validNumber = int.TryParse(Console.ReadLine(), out numericValue);
            Console.WriteLine($"Sorry, but {numericValue} is not a valid number");


        } while (numericValue <= 5 && numericValue >= 10);

        Console.WriteLine($"Awesome! {numericValue} is just what I was looking for!");



    }

    public void CodeProject2()
    {
        

    }
}