

public class CodeBlocksChallenge
{

    public void CBChallenge()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = true;
        foreach (int number in numbers)
        {

            total += number;

            if (number == 42)
            {

            }
        }
        if (found)
        {
            Console.WriteLine("Set contains 42");
        }
        Console.WriteLine($"Total: {total}");

    }



}